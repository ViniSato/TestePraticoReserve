using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Voos.Data.Dados;
using Voos.Domain.Models;
using Voos.Services.Interfaces;

namespace Voos.Services.AppServices
{
    public class VoosServices : IVoosServices
    {
        private readonly VoosDados _voosDados;

        public VoosServices(VoosDados voosDados)
        {
            _voosDados = voosDados;
        }

        public async Task<Voo> GetVoo(string origem, string destino, string data)
        {
            try
            {
                var disponibilidadeVoos = await _voosDados.ObterDisponibilidadeVoos(origem, destino, data);

                var voo = new Voo
                {
                };

                return voo;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
