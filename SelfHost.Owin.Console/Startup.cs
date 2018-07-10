using Owin;

namespace SelfHost.Owin.Console
{
    internal class Startup
    {
        public void Configuration (IAppBuilder app)
        {
            app.Use((x, next) =>
            {
                x.Response.ContentType = "text/html";
                return next.Invoke();
            });
            app.Use((x, next) =>
            {
                x.Response.WriteAsync("1 Before");
                next.Invoke();
                return x.Response.WriteAsync("1 After");
            });
            app.Use((x, next) =>
            {
                x.Response.WriteAsync("2 Before");
                next.Invoke();
                return x.Response.WriteAsync("2 After");
            });
            app.Run(x => x.Response.WriteAsync("<br/>hello world<br/>"));

            ////有关如何配置应用程序的详细信息，请访问 http://go.microsoft.com/fwlink/?LinkID=316888
            ////管线自由组合
            //app.Use<HelloMiddlerware>();
            ////Run是插入一个中间件，并终止继续往下流
            //app.Run(x => x.Response.WriteAsync("good"));
            ////此中间件将不执行
            //app.Use<HelloMiddlerware>();
            //app.UseErrorPage();
            //app.Run(x => x.Response.WriteAsync("hello world"));
        }
    }
}