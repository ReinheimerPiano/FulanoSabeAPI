using FulanoSabeAPI.Models;
using FulanoSabeAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FulanoSabeAPI.Controllers
{
    public class PedidoController : ApiController<Pedido>
    {
        public PedidoController(CrudService<Pedido> servico) : base(servico)
        {
        }
    }
}
