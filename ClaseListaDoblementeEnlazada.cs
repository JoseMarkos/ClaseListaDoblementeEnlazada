using System;
using System.Collections.Generic;

namespace ClaseListaDoblementeEnlazada
{
    public sealed class ClaseListaDoblementeEnlazada
    {
		public LinkedList<object> ListaDoblementeEnlazada {get; private set;}

		public ClaseListaDoblementeEnlazada()
		{
			ListaDoblementeEnlazada = new LinkedList<object>();
		}

		public void AgregarPrimero(object nuevoNodo)
		{
			ListaDoblementeEnlazada.AddFirst(nuevoNodo);
		}

		public void AgregarUltimo(object nuevoNodo)
		{
			ListaDoblementeEnlazada.AddLast(nuevoNodo);
		}

		public void AgregarDespuesDe(object nodo, object nuevoNodo)
		{
			if (!ListaDoblementeEnlazada.Contains(nodo))
			{
				throw new ArgumentOutOfRangeException("El nodo no existe.");
			}

			var node 	= ListaDoblementeEnlazada.Find(nodo);
			var newNode = new LinkedListNode<object>(nuevoNodo);
			ListaDoblementeEnlazada.AddAfter(node, newNode);
		}

		public void Eliminar(object nodo)
		{
			if (!ListaDoblementeEnlazada.Contains(nodo))
			{
				throw new ArgumentOutOfRangeException("El nodo no existe.");
			}

			ListaDoblementeEnlazada.Remove(nodo);
		}
    }
}
