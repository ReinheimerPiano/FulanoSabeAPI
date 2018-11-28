using LiteDB;
using FulanoSabeAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FulanoSabeAPI.Database
{
    public class Configuration
    {
        public static void Configure(string conString)
        {
            using (var banco = new LiteDatabase(conString))
            {
                var usuarios = banco.GetCollection<Usuario>();
                usuarios.EnsureIndex(u => u.Email, true);
                usuarios.EnsureIndex(u => u.Cpf, true);

            }
        }
    }
}
