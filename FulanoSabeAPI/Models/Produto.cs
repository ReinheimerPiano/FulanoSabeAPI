using FulanoSabeAPI.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FulanoSabeAPI.Models
{
    public class Produto : IEntidade
    {
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }

        public string Descricao { get; set; }

        public Decimal PrecoBase { get; set; }

        public int QtdProducaoMes { get; set; }


        public string[] Imagens { get; set; }

        public string ImagemP { get; set; }
    }
}
