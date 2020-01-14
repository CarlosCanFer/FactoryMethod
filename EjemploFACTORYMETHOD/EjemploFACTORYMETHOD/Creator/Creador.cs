using EjemploFACTORYMETHOD.Interfaces;

namespace EjemploFACTORYMETHOD
{
    // La clase Creator declara el método de fábrica que se supone que debe devolver
    // un objeto de una clase de Producto. Las subclases del Creador generalmente proporcionan
    // la implementación de este método.
    abstract class Creador
    {
        // Tenga en cuenta que el Creador también puede proporcionar alguna implementación predeterminada de
        // el método de fábrica.
        public abstract IButton FactoryMethod();

        // También tenga en cuenta que, a pesar de su nombre, el principal del Creador
        // la responsabilidad no es crear productos. Por lo general, contiene algunos
        // lógica empresarial central que se basa en objetos de Producto, devueltos por
        // método de fábrica. Las subclases pueden cambiar indirectamente esa lógica empresarial
        // anulando el método de fábrica y devolviendo un tipo diferente de
        // producto de ella.
        public string SomeOperation()
        {
            // Llame al método de fábrica para crear un objeto Producto.
            var Button = FactoryMethod();
            // Ahora, usa el producto.
            var result = "Creador: El mismo código del creador acaba de funcionar "
                + Button.Operation();

            return result;
        }
    }
}
