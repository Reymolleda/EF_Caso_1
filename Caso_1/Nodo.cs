using System;
using System.Collections.Generic;
using System.Text;

namespace Caso_1
{
    internal class Nodo
    {
        public Pedido dato;
        public Nodo next;
        public Nodo izquierdo;
        public Nodo derecho;

        public void ImprimirDatos()
        {
            Console.WriteLine("ID:{0}| Prioridad{1}| Pedido:{2}| Cliente:{3}| Costo: {4}", dato.id, dato.prioridad, dato.pedido, dato.cliente, dato.costo);
        }
    }
}
