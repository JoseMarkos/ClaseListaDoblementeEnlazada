# ClaseListaDoblementeEnlazada
Para proyecto de Progra IIB en Grupo

## Clase Dispositivo

Originalmente para demostrar que la clase ClaseListaDoblementeEnlazada soporta una instancia de cualquier clase. Pero no es cierto para el metodo *BuscarPorId* el cual debuelve una instancia de la clase Dispositivo. Si se quiere dejar ese nivel de acoplamiento entre las clases se puede dejar de la forma actual.

### Propuesta para seguir con la idea original

Para seguir con la idea original el metodo *BuscarPorId* podria debolver un *object* y hacer el cast afuera de la clase por ejemplo en el archivo Program.cs

<code>
  var encontrado = (Dispositivo)lista.BuscarPorId(3);
  System.Console.WriteLine(encontrado.ID);
</code>

## Clase ClaseListaDoblementeEnlazada
