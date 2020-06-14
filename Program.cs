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
                MyProperty = 4,
                ID = 2
            };
            var instanciaTres = new Dispositivo
            {
                MyProperty = 5,
                ID = 3
            };
            lista.AgregarPrimero(instancia);
            lista.AgregarDespuesDe(instancia, instanciaDos);
            lista.AgregarDespuesDe(instanciaDos, instanciaTres);
     

            var dispositivo = lista.BuscarPorId(2, true);
            var casteado = (Dispositivo)dispositivo.Next.Value;
            var casteadoPrev = (Dispositivo)dispositivo.Previous.Value;
            System.Console.WriteLine("next");
            System.Console.WriteLine(casteado.ID);
            System.Console.WriteLine("previous");
            System.Console.WriteLine(casteadoPrev.ID);

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
