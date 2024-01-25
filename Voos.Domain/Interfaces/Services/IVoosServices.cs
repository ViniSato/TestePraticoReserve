using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Voos.Domain.Models;

namespace Voos.Services.Interfaces
{
    public interface IVoosServices
    {
        Task<Voo> GetVoo(string origem, string destino, string data);
    }
}
