using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using WNG_Sequences.Infra;

namespace WNG_Sequences.WebUI
{
    public class Bootstrapper
    {
        public static void Bootstrap()
        {
            //RouteConfigurator.RegisterRoutes(RouteTable.Routes);
            ControllerBuilder.Current.SetControllerFactory(new WindsorControllerFactory(IoC.Container));
            WindsorConfigurator.Configure();
        }
    }
}