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
            var instanciaTres = new DispositivoHijo2
            {
                MyProperty = 5,
                ID = 3,
                Hola = 500
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

            System.Console.WriteLine();
            System.Console.WriteLine("Buscar id 4");
            
            var encontrado = lista.BuscarPorId(4);
            var tipo = encontrado.GetType();

            if (tipo == typeof(DispositivoHijo1))
            {
                var hola = (DispositivoHijo1)encontrado;
                MostrarDispositivo(hola);
            }

            if (tipo == typeof(DispositivoHijo2))
            {
                var hola = (DispositivoHijo2)encontrado;
                MostrarDispositivo(hola);
            }

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

        private static void MostrarDispositivo(DispositivoHijo1 dispositivo)
        {
            System.Console.WriteLine(dispositivo.ID);
            System.Console.WriteLine(dispositivo.MyProperty);
            System.Console.WriteLine(dispositivo.Descripcion);
        }

        private static void MostrarDispositivo(DispositivoHijo2 dispositivo)
        {
            System.Console.WriteLine(dispositivo.ID);
            System.Console.WriteLine(dispositivo.MyProperty);
            System.Console.WriteLine(dispositivo.Hola);
        }

    }
}
