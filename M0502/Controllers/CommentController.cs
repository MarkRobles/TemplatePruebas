using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace M0502.Controllers
{
    public class CommentController : Controller
    {
        // GET: Comment
        public ActionResult Index()
        {
            var Comment = new Models.Comment();
            Comment.Subject = "Buen Producto";
            Comment.HtmlSubject = "El producto es <i>muy bueno</i> y el precio es <i>excelente!!!</i>";

            return View(Comment);
        }


        //Para que no se pueda invocar desde la url, solo desde otras vistas
        [ChildActionOnly]
        public ActionResult _CommentList()
        {
            var VM = new Models.VielModelComments();
            var Commets =
                VM.Comments.Take(5);
            return View(Commets);
        }

        [ChildActionOnly]
        public ActionResult _CommentsListById(int id)
        {
            var VM = new Models.VielModelComments();
            var Comments = VM.Comments.Where(c => c.ID == id);
            return View("_CommentList",Comments);
        }
    }
}