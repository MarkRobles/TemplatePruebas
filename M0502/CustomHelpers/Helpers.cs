using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace M0502.CustomHelpers
{
    public static class Helpers
    {

        //Crear helper  que devuelva la hora actual del servidor
        public static MvcHtmlString CurrentTime(this HtmlHelper helper)
        {
            return new MvcHtmlString(DateTime.Now.ToShortTimeString());
        }

        public static MvcHtmlString DataGridFor(this HtmlHelper helper, IEnumerable items)
        {
            var sb = new StringBuilder();
            //preguntar  si hay elementos

            if (items != null)
            {
                sb.Append("<table class=\"DataGrid\">");
                string[] PropertyNames = null;
                bool Alt = false;

                //Recorrer cada elemento
                foreach (var item in items)
                {
                    //Verificar si tenemos los nombres de las propiedades (columnas )
                    if (PropertyNames == null)
                    {
                        //Obtener nombres de propiedades, que no sean tipos referencia ó que si sean tipo string
                        PropertyNames =
                            item.GetType().GetProperties().
                            Where(p => !p.PropertyType.IsClass ||
                            p.PropertyType == typeof(string)).Select(p => p.Name).ToArray();

                        //Agregar encabezado a la tabla
                        sb.Append("<tr>");

                        foreach (var e in PropertyNames)
                        {
                            //Obtener metadata de las propiedades del modelo si existe
                            string DisplayName =
                                ModelMetadataProviders.Current
                                .GetMetadataForProperty(null, item.GetType(), e).DisplayName;
                            //Si no hay metada muestra el encabezado de la propiedad
                            DisplayName = DisplayName ?? e;

                            //Agregar titulo para la columna
                            sb.AppendFormat("<th>{0}</th>", DisplayName);
                        }
                        sb.Append("</tr>");

                    }

                    //Agregar valores del registro actual
                    sb.AppendFormat("<tr {0}>" 
                       ,Alt?"class=\"Alt\"":"");
                    //Recorrer valores

                    foreach (var p in PropertyNames)
                    {
                        sb.AppendFormat("<td>{0}</td>",item.GetType().GetProperty(p).GetValue(item));
                    }
                    sb.Append("</tr>");
                    Alt = !Alt; //Filas alternadas
                }
                sb.Append("</table>");
            }
            return new MvcHtmlString(sb.ToString());
        }

    }


}