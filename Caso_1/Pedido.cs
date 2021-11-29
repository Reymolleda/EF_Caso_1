using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Caso_1
{
    internal class Pedido
    {
        public int id, prioridad;
        public string pedido, cliente;
        public int costo;

        public Pedido(int id, int prioridad, string pedido, string cliente, int costo)
        {
            this.id = id;
            this.prioridad = prioridad;
            this.pedido = pedido;
            this.cliente = cliente;
            this.costo = costo;
        }
    }
}
