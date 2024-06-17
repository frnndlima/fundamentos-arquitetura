using DI.Cases;
using Microsoft.AspNetCore.Mvc;

namespace DI.Controllers
{
    public class ServiceLocatorController : Controller
    {
        // Interface que expoe os métodos de consultas etc ao container nativo de injeção de dependência 
        private readonly IServiceProvider _serviceProvider;

        public ServiceLocatorController(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void Index()
        {
            // GetRequiredService - Retorna null se não estiver registrado
            _serviceProvider.GetRequiredService<IClienteServices>().AdicionarCliente(new Cliente());
        }
    }
}
