using FulanoSabeAPI.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FulanoSabeAPI.Models
{
    public class Personalizacao : IEntidade
    {
        public int Id { get; set; }
        [Required]
        public string Descricao { get; set; }
        [Required]
        public decimal Preco { get; set; }
        [Required]
        public DateTime Tempo { get; set; }

        public Boolean Default { get; set; }
    }
}
