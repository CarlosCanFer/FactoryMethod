using EjemploFACTORYMETHOD.Interfaces;

namespace EjemploFACTORYMETHOD.Creator
{
    /// <summary>
    /// Los creadores concretos anulan el método de fábrica para cambiar el tipo de producto resultante.
    /// </summary>
    class WindowsDialog : Creador
    {
        // Tenga en cuenta que la firma del método todavía usa el producto abstracto
        // tipo, a pesar de que el producto concreto realmente es devuelto por
        // método. De esta manera, el Creador puede mantenerse independiente del producto concreto
        // clases.
        public override IButton FactoryMethod()
        {
            return new WindowsButton();
        }
    }    
}
