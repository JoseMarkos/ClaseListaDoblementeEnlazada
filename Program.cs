using System;
using System.Collections.Generic;

namespace ClaseListaDoblementeEnlazada
{
    class Program
    {
        static void Main(string[] args)
        {
            var lista = new ClaseListaDoblementeEnlazada();
            var instancia = new Dispositivo();
            instancia.MyProperty = 3;
			instancia.ID = 1;
            var instanciaDos = new Dispositivo
            {
                MyProperty 	= 4,
				ID 			= 2
            };
            var instanciaTres = new Dispositivo
            {
                MyProperty 	= 5,
				ID			= 3
            };
            lista.AgregarPrimero(instancia);
            lista.AgregarDespuesDe(instancia, instanciaDos);
            lista.AgregarDespuesDe(instanciaDos, instanciaTres);
            PrintList(lista.GetEnumerator());
            lista.EliminarDespuesDe(instancia);
			System.Console.WriteLine();
			PrintList(lista.GetEnumerator());
			System.Console.WriteLine();
			System.Console.WriteLine(lista.BuscarPorId(1).ID);
			System.Console.WriteLine(lista.BuscarPorId(1).MyProperty);
        }

        private static void PrintList(IEnumerator<object> enumerator)
        {
            while (enumerator.MoveNext())
            {
                var dispositivo = (Dispositivo)enumerator.Current;
                System.Console.WriteLine(dispositivo.MyProperty);
            }
			enumerator.Dispose();
        }
    }
}
