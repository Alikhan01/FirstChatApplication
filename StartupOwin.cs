//using System;
//using System.Threading.Tasks;
//using Microsoft.Owin;
//using Owin;

//[assembly: OwinStartup(typeof(SimpleChatApplicationfrom_Waqar.StartupOwin))]

//namespace SimpleChatApplicationfrom_Waqar
//{
//    public class StartupOwin
//    {
//        public void Configuration(IAppBuilder app)
//        {
//            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=316888
//        }
//    }
//}

using Microsoft.Owin;

using Owin;

[assembly: OwinStartup(typeof(SimpleChatApplicationfrom_Waqar.StartupOwin))]
namespace SimpleChatApplicationfrom_Waqar
{
   public class StartupOwin
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();

        }
    }
}