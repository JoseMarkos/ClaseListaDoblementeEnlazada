# ClaseListaDoblementeEnlazada
Para proyecto de Progra IIB en Grupo

## Clases Dispositivo, DispositivoHijo1 y DispositivoHijo2

Añadidas para demostrar que la clase **ClaseListaDoblementeEnlazada** soporta una instancia de cualquier clase.


## Clase ClaseListaDoblementeEnlazada

### BuscarPorId
  *int id*
  
  *return object*
  
 ### BuscarPorId
  *int id*
  
  *bool devolverNodo*
  
  *return LinkedListNode&#60;object&#x3e;*


## Propuesta para mostrar propiedades de las clases

Hay que hacer el cast afuera de la clase por ejemplo en el archivo Program.cs

```
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
```

## Nodo
Ejemplo usando nodos:

```
 var nodo = lista.BuscarPorId(3, true);
 var nodoNext = (Dispositivo)nodo.Next.Value;
 var nodoPrevious = (Dispositivo)nodo.Previous.Value;
 
 System.Console.WriteLine("Next");
 System.Console.WriteLine(nodoNext.ID);
 System.Console.WriteLine("Previous");
 System.Console.WriteLine(nodoPrevious.ID);
```

