using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FulanoSabeAPI.Interface
{
    public interface IEntidade
    {
        int Id { get; set; }

        DateTime CreatedAt { get; set; }
    }
}
