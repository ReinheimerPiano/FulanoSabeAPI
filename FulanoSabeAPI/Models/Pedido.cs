using FulanoSabeAPI.Interface;
using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FulanoSabeAPI.Models
{
    public class Pedido : IEntidade
    {
        public int Id { get; set; }
        public List<Item> Itens { get; set; }
        [BsonRef]
        public Usuario Usuario { get; set; }
    }
}
