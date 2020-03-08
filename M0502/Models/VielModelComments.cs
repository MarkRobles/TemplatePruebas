using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace M0502.Models
{
    public class VielModelComments
    {
        public List<Comment> Comments { get; set; }


        public VielModelComments()
        {
            Comments = new List<Comment>
            {
                new Comment
                {
                    ID=1,
                    Subject="C 1",
                    HtmlSubject = "Comentario 1"
                },
                 new Comment
                {
                    ID=1,
                    Subject="C 2",
                    HtmlSubject = "Comentario 2"
                },
                  new Comment
                {
                    ID=2,
                    Subject="C 3",
                    HtmlSubject = "Comentario 3"
                },
                   new Comment
                {
                    ID=3,
                    Subject="C 4",
                    HtmlSubject = "Comentario 4"
                },
                    new Comment
                {
                    ID=1,
                    Subject="C 5",
                    HtmlSubject = "Comentario 5"
                },
                     new Comment
                {
                    ID=6,
                    Subject="C 6",
                    HtmlSubject = "Comentario 6"
                },
                      new Comment
                {
                    ID=1,
                    Subject="C 7",
                    HtmlSubject = "Comentario 7"
                },
                       new Comment
                {
                    ID=5,
                    Subject="C 8",
                    HtmlSubject = "Comentario 8"
                },
                        new Comment
                {
                    ID=1,
                    Subject="C 9",
                    HtmlSubject = "Comentario 9"
                },
                         new Comment
                {
                    ID=6,
                    Subject="C 10",
                    HtmlSubject = "Comentario 10"
                }
            };

        }
    }
}