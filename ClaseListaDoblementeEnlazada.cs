using System;
using System.Collections.Generic;

namespace ClaseListaDoblementeEnlazada
{
	public sealed class ClaseListaDoblementeEnlazada
	{
		private LinkedList<object> ListaDoblementeEnlazada;

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
			Contiene(nodo);
			var node = ListaDoblementeEnlazada.Find(nodo);
			var newNode = new LinkedListNode<object>(nuevoNodo);
			ListaDoblementeEnlazada.AddAfter(node, newNode);
		}

		public void Eliminar(object nodo)
		{
			Contiene(nodo);
			ListaDoblementeEnlazada.Remove(nodo);
		}

		public void EliminarPrimero(object nodo)
		{
			Contiene(nodo);
			ListaDoblementeEnlazada.RemoveFirst();
		}

		public void EliminarUltimo(object nodo)
		{
			Contiene(nodo);
			ListaDoblementeEnlazada.RemoveLast();
		}

		public void EliminarDespuesDe(object nodo)
		{
			Contiene(nodo);
			var node = ListaDoblementeEnlazada.Find(nodo);

			if (node.Next == null)
			{
				throw new ArgumentOutOfRangeException("El nodo no existe.");
			}

			ListaDoblementeEnlazada.Remove(node.Next);
		}

		public Dispositivo BuscarPorId(int id)
		{
			var enumerator = ListaDoblementeEnlazada.GetEnumerator();

			while (enumerator.MoveNext())
			{
				var dispositivo = (Dispositivo)enumerator.Current;

				if (dispositivo.ID == id)
				{
					enumerator.Dispose();
					return dispositivo;
				}
			}
			enumerator.Dispose();
			return new Dispositivo();
		}

		private void Contiene(object nodo)
		{
			if (!ListaDoblementeEnlazada.Contains(nodo))
			{
				throw new ArgumentOutOfRangeException("El nodo no existe.");
			}
		}

		public IEnumerator<object> GetEnumerator()
		{
			return ListaDoblementeEnlazada.GetEnumerator();
		}

		public Dispositivo Primero()
		{
			return (Dispositivo)ListaDoblementeEnlazada.First.Value;
		}
	}
}
