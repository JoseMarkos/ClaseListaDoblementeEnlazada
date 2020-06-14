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
            var instanciaDos = new Dispositivo
            {
                MyProperty = 4
            };
            var instanciaTres = new Dispositivo
            {
                MyProperty = 5
            };
            instancia.MyProperty = 3;
            lista.AgregarPrimero(instancia);
            lista.AgregarDespuesDe(instancia, instanciaDos);
            lista.AgregarDespuesDe(instanciaDos, instanciaTres);
            PrintList(lista.GetEnumerator());
            lista.EliminarDespuesDe(instancia);
			System.Console.WriteLine();
			PrintList(lista.GetEnumerator());
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
