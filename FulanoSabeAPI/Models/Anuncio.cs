using FulanoSabeAPI.Interface;
using FulanoSabeAPI.Validacoes;
using LiteDB;
using System;
using System.ComponentModel.DataAnnotations;

namespace FulanoSabeAPI.Models
{
    public class Anuncio : IEntidade
    {
        public int Id { get; set; }
        [BsonRef]
        public Produto Produto { get; set; }

        public DateTime Criado { get; set; }

        public TimeSpan Duracao { get; set; }

    }
}
