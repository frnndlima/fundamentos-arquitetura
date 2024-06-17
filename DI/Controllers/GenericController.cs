using DI.Cases;
using Microsoft.AspNetCore.Mvc;

namespace DI.Controllers
{
    public class GenericController : Controller
    {
        private readonly IGenericRepository<Cliente> _clienteRepository;

        public GenericController(IGenericRepository<Cliente> clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public void Index()
        {
            _clienteRepository.Adicionar(new Cliente());
        }
    }
}
