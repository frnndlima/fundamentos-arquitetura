using DI.Cases;
using Microsoft.AspNetCore.Mvc;

namespace DI.Controllers
{
    public class MultiplasClassesController : Controller
    {
        private readonly Func<string, IService> _serviceAccesor;

        public MultiplasClassesController(Func<string, IService> serviceAccesor)
        {
            _serviceAccesor = serviceAccesor;
        }

        public string Index()
        {
            return _serviceAccesor("A").Retorno();  
            //return _serviceAccesor("B").Retorno();  
            //return _serviceAccesor("C").Retorno();  
        }
    }
}
