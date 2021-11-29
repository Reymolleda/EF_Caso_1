using System;
using System.Collections.Generic;
using System.Text;

namespace Caso_1
{
    internal class ArbolBinario
    {
        public Nodo raiz;

        public Nodo GetRaiz()
        {
            return raiz;
        }

        public void InsertarNodo(Pedido dato)
        {
            Nodo puntero, padre;
            Nodo nuevoNodo = new Nodo();
            nuevoNodo.dato = dato;
            if (raiz != null)
            {
                puntero = raiz;
                while (true)
                {
                    padre = puntero;
                    if (dato.id < puntero.dato.id)
                    {
                        puntero = puntero.izquierdo;
                        if (puntero == null)
                        {
                            padre.izquierdo = nuevoNodo;
                            break;
                        }
                    }
                    else
                    {
                        puntero = puntero.derecho;
                        if (puntero == null)
                        {
                            padre.derecho = nuevoNodo;
                            break;
                        }
                    }
                }
            }
            else
            {
                raiz = nuevoNodo;
            }
        }

        public void PreOrder(Nodo raiz)
        {
            if (raiz != null)
            {
                raiz.ImprimirDatos();
                PreOrder(raiz.izquierdo);
                PreOrder(raiz.derecho);
            }
        }

        public void InOrder(Nodo raiz)
        {
            if (raiz != null)
            {
                InOrder(raiz.izquierdo);
                raiz.ImprimirDatos();
                InOrder(raiz.derecho);
            }
        }

        public void PostOrder(Nodo raiz)
        {
            if (raiz != null)
            {
                PostOrder(raiz.izquierdo);
                PostOrder(raiz.derecho);
                raiz.ImprimirDatos();
            }
        }

       
    }
}
