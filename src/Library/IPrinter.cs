namespace Full_GRASP_And_SOLID.Library
{
    //Al usar esta interfaz para ambos tipos de impresión evitamos preguntar por el destino
    //cumpliendo así con el patrón de Polimorfismo.
    //Esta interfaz al igual que las dos clases que la implementan cumplen con el patrón de SRP
    //porque sólo tienen la función de impresión.
    //También se cumple con el principio de OCP ya que si se quiere agregar otro método de impresión
    //sólo es necesario crear una clase que implemente la interfaz IPrinter, sin necesidad
    //de modificar ésta o cualquier otra clase.
    public interface IPrinter
    {
        void PrintRecipe(Recipe recipe);
    }
}