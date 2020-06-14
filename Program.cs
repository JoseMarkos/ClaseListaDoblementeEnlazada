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
            var instanciaCuatro = new DispositivoHijo1
            {
                ID = 4,
                MyProperty = 6,
                Descripcion = "hola"
            };
            lista.AgregarPrimero(instancia);
            lista.AgregarDespuesDe(instancia, instanciaDos);
            lista.AgregarDespuesDe(instanciaDos, instanciaTres);
            lista.AgregarUltimo(instanciaCuatro);
            PrintList(lista.GetEnumerator());
            lista.EliminarDespuesDe(instancia);
            System.Console.WriteLine();
            PrintList(lista.GetEnumerator());
            System.Console.WriteLine("Buscar id 4");
            System.Console.WriteLine(lista.BuscarPorId(4).ID);
            System.Console.WriteLine(lista.BuscarPorId(4).MyProperty);
            var omg = (DispositivoHijo1)lista.BuscarPorId(4);
            System.Console.WriteLine(omg.Descripcion);
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
