using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Delivery: Persona
    {
        public int IdDelivery { get; set; }
        public int Salario { get; set; }
        public int TiempoDemora { get; set; }

        public int IdPedido{ get; set; }

    }
}
