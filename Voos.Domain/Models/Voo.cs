using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voos.Domain.Models
{
    public class Voo
    {
        public int voo {  get; set; }
        public string companhia {  get; set; }
        public string origem {  get; set; }
        public string destino {  get; set; }
        public DateTime partida {  get; set; }
        public DateTime chegada {  get; set; }
        public decimal tarifa {  get; set; }
    }
}
