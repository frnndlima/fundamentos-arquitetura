using DI.Cases;
using Microsoft.AspNetCore.Mvc;

namespace DI.Controllers
{
    public class VidaRealController : Controller
    {
        private readonly IClienteServices _clienteServices;

        public VidaRealController(IClienteServices clienteServices)
        {
            _clienteServices = clienteServices;
        }

        public void Index()
        {
            _clienteServices.AdicionarCliente(new Cliente());
        }
    }
}
