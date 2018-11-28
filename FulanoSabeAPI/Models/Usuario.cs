using FulanoSabeAPI.Interface;
using FulanoSabeAPI.Validacoes;
using LiteDB;
using System;
using System.ComponentModel.DataAnnotations;

namespace FulanoSabeAPI.Models
{
    public class Usuario : IEntidade
    {
        private string _email;
        public int Id { get; set; }
        public DateTime? CreatedAt { get; set; }
        [Required]
        [EmailAddress]
        public string Email
        {
            get => _email;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    _email = value;
                }
                else
                {
                    _email = value.ToLower();
                }
            }
        }
        [Required]
        public string Senha { get; set; }
        [Cpf]
        public string Cpf { get; set; }

        public TipoUsuario Tipo { get; set; }
    }

    public enum TipoUsuario
    {
        Admin, Comprador, Vendedor
    }
}
