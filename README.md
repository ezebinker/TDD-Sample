# TDD-Sample
Proyecto desarrollado en el lenguaje C# (.NET Framework) que ejecuta pruebas de código unitarias a partir de una clase con operaciones matemáticas.
Esta estrategia de testing se denomina **Test Driven Development** (Desarrollo dirigido por pruebas), en el cual se escriben todas las pruebas del código primero, y luego se realiza una Refactorización. 

## Clases
Proyecto de tipo Class Library que incluye dentro del mismo el archivo *Matematica.cs*

### Matematica.cs
Es la clase estática que se encarga de realizar las operaciones matemáticas.
Contiene los métodos sumar y dividir. Ambos reciben como parámetro dos números enteros. 

## UnitTestProject
Proyecto de tipo UnitTestProject, el cual permitirá crear pruebas unitarias de código, y posteriormente poder *testearlas*. Contiene el archivo *PruebasMate.cs*

### [TestClass] PruebasMate.cs
Es la clase que realiza las pruebas unitarias. Cada método corresponde a una prueba. 
* El método Sumar() probará realizar diversas sumas.
* El método DividirPorCero dará *OK*, si hay una excepción de división por cero. 
* El método Dividir testeará el método Dividir de *Matematica.cs*
