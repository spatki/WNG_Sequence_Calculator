using WNG_Sequences.Service;
using WNG_Sequences.Infra;
using WNG_Sequences.WebUI.Controllers;
using WNG_Sequences.WebUI.Models;

namespace WNG_Sequences.WebUI
{
    public class WindsorConfigurator
    {
        public static void Configure()
        {
            WindsorRegistrar.RegisterAllFromAssemblies("WNG_Sequences.Service");
            WindsorRegistrar.RegisterAllFromAssemblies("WNG_Sequences.WebUI");
        }
    }
}