using Microsoft.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfHost.Owin.Console
{
    public class HelloMiddlerware : OwinMiddleware
    {
        public HelloMiddlerware(OwinMiddleware next)
            : base(next)
        {
        }

        public override Task Invoke(IOwinContext context)
        {
            context.Response.Write("hello" + DateTime.Now);//管道继续往下走
            return Next.Invoke(context);
        }
    }
}
