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

		public void AgregarPrimero(object nuevoObjeto)
		{
			ListaDoblementeEnlazada.AddFirst(nuevoObjeto);
		}

		public void AgregarUltimo(object nuevoObjeto)
		{
			ListaDoblementeEnlazada.AddLast(nuevoObjeto);
		}

		public void AgregarDespuesDe(object objeto, object nuevoObjeto)
		{
			Contiene(objeto);
			var nodo = ListaDoblementeEnlazada.Find(objeto);
			var nuevoNodo = new LinkedListNode<object>(nuevoObjeto);
			ListaDoblementeEnlazada.AddAfter(nodo, nuevoNodo);
		}

		public void Eliminar(object objeto)
		{
			Contiene(objeto);
			ListaDoblementeEnlazada.Remove(objeto);
		}

		public void EliminarPrimero()
		{
			ListaNoVacia();
			ListaDoblementeEnlazada.RemoveFirst();
		}

		public void EliminarUltimo()
		{
			ListaNoVacia();
			ListaDoblementeEnlazada.RemoveLast();
		}

		public void EliminarDespuesDe(object objeto)
		{
			Contiene(objeto);
			var nodo = ListaDoblementeEnlazada.Find(objeto);

			if (nodo.Next == null)
			{
				throw new ArgumentOutOfRangeException("El objeto no existe.");
			}

			ListaDoblementeEnlazada.Remove(nodo.Next);
		}

		public object BuscarPorId(int id)
		{
			var enumerator = ListaDoblementeEnlazada.GetEnumerator();

			while (enumerator.MoveNext())
			{
				var dispositivo = (Dispositivo)enumerator.Current;

				if (dispositivo.ID == id)
				{
					enumerator.Dispose();
					return enumerator.Current;
				}
			}
			enumerator.Dispose();
			return new object();
		}

		public LinkedListNode<object> BuscarPorId(int id, bool devolverNodo)
		{
			var enumerator = ListaDoblementeEnlazada.GetEnumerator();

			while (enumerator.MoveNext())
			{
				var dispositivo = (Dispositivo)enumerator.Current;

				if (dispositivo.ID == id)
				{
					enumerator.Dispose();
					return ListaDoblementeEnlazada.Find(dispositivo);
				}
			}
			enumerator.Dispose();
			return new LinkedListNode<object>(new Dispositivo());
		}


		private void Contiene(object objeto)
		{
			if (!ListaDoblementeEnlazada.Contains(objeto))
			{
				throw new ArgumentOutOfRangeException("El objeto no existe.");
			}
		}

		private void ListaNoVacia()
		{
			if (ListaDoblementeEnlazada.Count == 0)
			{
				throw new ArgumentOutOfRangeException("La lista est� vaci�.");
			}
		}

		public IEnumerator<object> GetEnumerator()
		{
			return ListaDoblementeEnlazada.GetEnumerator();
		}

		public object Primero()
		{
			return ListaDoblementeEnlazada.First.Value;
		}

		public LinkedListNode<object> Primero(bool devolverNodo)
		{
			return ListaDoblementeEnlazada.First;
		}
	}
}
