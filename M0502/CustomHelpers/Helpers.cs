using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace M0502.CustomHelpers
{
    public static class Helpers
    {

        //Crear helper  que devuelva la hora actual del servidor
        public static MvcHtmlString CurrentTime(this HtmlHelper helper) {
            return new MvcHtmlString(DateTime.Now.ToShortTimeString());
        }

    }
}