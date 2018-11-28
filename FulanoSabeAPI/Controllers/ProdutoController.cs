using FulanoSabeAPI.Models;
using FulanoSabeAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FulanoSabeAPI.Controllers
{
    public class ProdutoController : ApiController<Produto>
    {
        public ProdutoController(CrudService<Produto> servico) : base(servico)
        {
        }
    }
}
