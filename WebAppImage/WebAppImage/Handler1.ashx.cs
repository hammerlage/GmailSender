using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;

namespace WebAppImage
{
    /// <summary>
    /// Summary description for Handler1
    /// </summary>
    public class Handler1 : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "image/png";
            context.Response.WriteFile("C:\\workspace\\poc\\liverpool.jpg");
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}