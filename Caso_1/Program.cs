using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caso_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Pedido p1 = new Pedido(8, 1, "Hamburguesa de pollo", "Miguel Paredes", 12);
            Pedido p2 = new Pedido(3, 2, "KFC", "Reynaldo Molleda", 49);
            Pedido p3 = new Pedido(1, 3, "Pollo a la brasa", "Angelica Delgado", 62);
            Pedido p4 = new Pedido(9, 4, "Aeropuerto", "Lucero Arostegui", 18);
            Pedido p5 = new Pedido(6, 5, "Parrila familiar", "Estefany Quispe", 85);


            Nodo colapedido = null;
            ColaDePrioridad lista = new ColaDePrioridad();

            colapedido = lista.NewNodo(p1, p1.prioridad);
            colapedido = lista.Push(colapedido, p2, p2.prioridad);
            colapedido = lista.Push(colapedido, p3, p3.prioridad);
            colapedido = lista.Push(colapedido, p4, p4.prioridad);
            colapedido = lista.Push(colapedido, p5, p5.prioridad);

            ArbolBinario arbol = new ArbolBinario();

            arbol.InsertarNodo(p1);
            arbol.InsertarNodo(p2);
            arbol.InsertarNodo(p3);
            arbol.InsertarNodo(p4);
            arbol.InsertarNodo(p5);

            Console.WriteLine("*Ingreso de pedidos*");

            mostrarOrdenamientos(colapedido, lista, arbol);

            Pedido p0 = new Pedido(5, 0, "Especial Marino", "Pancracio Sardina", 30);
            colapedido = lista.Push(colapedido, p0, p0.prioridad);
            arbol.InsertarNodo(p0);

           Console.WriteLine("Ingresando prioridad a pedido: ID: " + p0.id + " - " + p0.cliente + "\n");
            mostrarOrdenamientos(colapedido, lista, arbol);

            Console.ReadKey();
        }

        static void mostrarOrdenamientos(Nodo colaEspera, ColaDePrioridad lista, ArbolBinario arbol)
        {
            Console.WriteLine("\nPedidos ingresados según registro de ingreso\n");
            lista.RecorrerCola(colaEspera);

            Console.WriteLine("\n-Pedidos en Preorder-\n");
            arbol.PreOrder(arbol.GetRaiz());

            Console.WriteLine("\n-Pedidos en Inorder-\n");
            arbol.InOrder(arbol.GetRaiz());

            Console.WriteLine("\n-Pedidos en Postorder-\n");
            arbol.PostOrder(arbol.GetRaiz());

        }
    }
}
