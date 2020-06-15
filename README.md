# ClaseListaDoblementeEnlazada
Para proyecto de Progra IIB en Grupo

## Clases Dispositivo, DispositivoHijo1 y DispositivoHijo2

Demos para demostrar que la clase **ClaseListaDoblementeEnlazada** soporta una instancia de cualquier clase.


## Clase ClaseListaDoblementeEnlazada

### BuscarPorId
  *int id*
  
  *return object*


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
