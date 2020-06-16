using System.Collections.Generic;

namespace ClaseListaDoblementeEnlazada
{
    class Program
    {
        static void Main(string[] args)
        {
            var lista = new ClaseListaDoblementeEnlazada();
            var instancia = new Dispositivo();
            instancia.Name = 3;
            instancia.ID = 1;
            var instanciaDos = new Dispositivo
            {
                Name = 4,
                ID = 2
            };
            var instanciaTres = new DispositivoHijo2
            {
                Name = 5,
                ID = 3,
                Hola = 500
            };
            var instanciaCuatro = new DispositivoHijo1
            {
                ID = 4,
                Name = 6,
                Descripcion = "hola"
            };
            lista.AgregarPrimero(instancia);
            lista.AgregarDespuesDe(instancia, instanciaDos);
            lista.AgregarDespuesDe(instanciaDos, instanciaTres);
            lista.AgregarUltimo(instanciaCuatro);
            System.Console.WriteLine("Cuatro dispositivos");
            MostrarIDDeLosElementos(lista.GetEnumerator());
            System.Console.WriteLine();
            System.Console.WriteLine("Eliminar despues de 1");
            lista.EliminarDespuesDe(instancia);
            MostrarIDDeLosElementos(lista.GetEnumerator());

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

            System.Console.WriteLine();
            System.Console.WriteLine("Next y prev de nodo con id 3");
            var nodo = lista.BuscarPorId(3, true);
            var nodoNext = (Dispositivo)nodo.Next.Value;
            var nodoPrevious = (Dispositivo)nodo.Previous.Value;
            System.Console.WriteLine("Next");
            System.Console.WriteLine(nodoNext.ID);
            System.Console.WriteLine("Previous");
            System.Console.WriteLine(nodoPrevious.ID);

        }

        private static void MostrarIDDeLosElementos(IEnumerator<object> enumerator)
        {
            while (enumerator.MoveNext())
            {
                var dispositivo = (Dispositivo)enumerator.Current;
                System.Console.WriteLine(dispositivo.ID);
            }
            enumerator.Dispose();
        }

        private static void MostrarDispositivo(DispositivoHijo1 dispositivo)
        {
            System.Console.WriteLine(dispositivo.ID);
            System.Console.WriteLine(dispositivo.Name);
            System.Console.WriteLine(dispositivo.Descripcion);
        }

        private static void MostrarDispositivo(DispositivoHijo2 dispositivo)
        {
            System.Console.WriteLine(dispositivo.ID);
            System.Console.WriteLine(dispositivo.Name);
            System.Console.WriteLine(dispositivo.Hola);
        }
    }
}
