using Microsoft.AspNetCore.Mvc;
using DemoDI.Cases;

namespace DemoDI.Controllers
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
