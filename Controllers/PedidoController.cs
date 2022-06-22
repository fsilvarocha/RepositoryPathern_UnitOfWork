using Microsoft.AspNetCore.Mvc;
using RepositoryPathern.Data;
using RepositoryPathern.Models;
using RepositoryPathern.Repositories.Interfaces;
using RepositoryPathern.Transaction.Interfaces;

namespace RepositoryPathern.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PedidoController : Controller
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly IPedidoRepository _pedidoRepository;
        private readonly IUnitOfWork _unitOfWork;

        public PedidoController(IClienteRepository clienteRepository,
                                IPedidoRepository pedidoRepository,
                                IUnitOfWork unitOfWork)
        {
            _clienteRepository = clienteRepository;
            _pedidoRepository = pedidoRepository;
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public Pedido Post()
        {
            Cliente cliente = new(1, "Fabricio");
            Pedido pedido = new Pedido
            {
                Id = 1,
                Qtde = 10,
                ClienteID = cliente.Id,
                Clientes = cliente
            };

            _clienteRepository.Add(cliente);
            _pedidoRepository.Add(pedido);
            try
            {
                _unitOfWork.Commit();
            }
            catch (System.Exception)
            {
                _unitOfWork.Rollback();
            }

            return pedido;
        }
    }
}