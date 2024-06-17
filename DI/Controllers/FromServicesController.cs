using DI.Cases;
using Microsoft.AspNetCore.Mvc;

namespace DI.Controllers
{
    public class FromServicesController : Controller
    {
        public void Index([FromServices] IClienteServices clienteServices)
        {
            clienteServices.AdicionarCliente(new Cliente());
        }
    }
}
