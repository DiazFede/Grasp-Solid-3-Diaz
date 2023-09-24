using System;
using System.IO;

namespace Full_GRASP_And_SOLID.Library
{
    public interface IPrinter
    {
       public void PrintRecipe(Recipe recipe);       
    }
}



//Para asignar la responsabilidad de impresion en diferentes destinos se esta utilizando el single responsibility principle (srp),
//para que cada clase tenga la unica responsabilidad de imprimir en un lugar especifico. Ademas, se puede decir que los objetos son
//tratados de manera polimorfica, ya que se puede llamar al metodo printrecipe definido en la interfaz. 
//Por ultimo, se cumple el LSP, debido a que el comportamiento de printrecipe es compatible en todas las implemetaciones.