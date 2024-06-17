using DI.Cases;
using Microsoft.AspNetCore.Mvc;

namespace DI.Controllers
{
    public class ServiceLocator2Controller : Controller
    {
        public void Index([FromServices] IServiceProvider serviceProvider)
        {
            serviceProvider.GetRequiredService<IClienteServices>().AdicionarCliente(new Cliente());
        }
    }
}
