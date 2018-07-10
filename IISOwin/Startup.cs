using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IISOwin
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.Run(async context =>
            {
                context.Response.ContentType = "text/plain";
                await context.Response.WriteAsync("hello world");
            });
        }
    }
}