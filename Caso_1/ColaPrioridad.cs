using System;
using System.Collections.Generic;
using System.Text;

namespace Caso_1
{
    internal class ColaDePrioridad
    {
        public void RecorrerCola(Nodo header)
        {
            Nodo temp = new Nodo();
            while (!isEmpty(header))
            {
                header.ImprimirDatos();
                temp = header;
                header = header.next;
            }
        }

        public Nodo NewNodo(Pedido dato, int prioridad)
        {
            Nodo temp = new Nodo();
            temp.dato = dato;
            temp.dato.prioridad = prioridad;
            temp.next = null;
            return temp;
        }

        public Nodo Push(Nodo header, Pedido dato, int prioridad)
        {
            Nodo puntero = header;
            Nodo temp = NewNodo(dato, prioridad);
            if (header.dato.prioridad > prioridad)
            {
                temp.next = header;
                header = temp;
            }
            else
            {
                while (puntero.next != null && puntero.next.dato.prioridad < prioridad)
                {
                    puntero = puntero.next;
                }
                temp.next = puntero.next;
                puntero.next = temp;
            }
            return header;
        }

        public bool isEmpty(Nodo header)
        {
            if (header == null) return true;
            return false;
        }
    }
}
