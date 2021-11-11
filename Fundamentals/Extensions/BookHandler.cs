using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fundamentals.Extensions
{
    public class BookHandler : IHttpHandler
    {
        public bool IsReusable => false;

        public void ProcessRequest(HttpContext context)
        {
            string title = context.Request.QueryString["title"];            

            context.Response.ContentType = "text/plain";
            context.Response.Output.Write($"Title of the book: {title}");
        }
    }
}