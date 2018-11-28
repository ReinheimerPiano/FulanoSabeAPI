using FulanoSabeAPI.Interface;
using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FulanoSabeAPI.Models
{
    public class Item :IEntidade
    {
        public int Id { get; set; }
        [BsonRef]
        public Produto Produto { get; set; }

        public int Quantidade { get; set; }

        public decimal Total { get; set; }
    }
}
