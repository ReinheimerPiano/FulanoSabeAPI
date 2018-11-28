using FulanoSabeAPI.Models;
using FulanoSabeAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FulanoSabeAPI.Controllers
{
    public class AnuncioController : ApiController<Anuncio>
    {
        public AnuncioController(CrudService<Anuncio> servico) : base(servico)
        {
        }
    }
}
