using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Pedido
    {
        public int IdPedido { get; set; }
        public int IdCliente { get; set; }
        public string Tipo { get; set; }
        public string HorarioEstimado { get; set; }
        public int CostoFinal { get; set; }

    }
}
