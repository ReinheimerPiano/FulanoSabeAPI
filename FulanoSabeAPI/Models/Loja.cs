using FulanoSabeAPI.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FulanoSabeAPI.Models
{
    public class Loja : IEntidade
    {
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; } // propriedade

        public string Descricao { get; set; } // propriedade

        public string[] Imagens {get; set;} // propriedade
    }
}
