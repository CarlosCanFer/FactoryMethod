using EjemploFACTORYMETHOD.Interfaces;

namespace EjemploFACTORYMETHOD
{
    // Productos concretos proporcionan diversas implementaciones del producto
    // interfaz.
    public class WindowsButton : IButton
    {
        public string Operation()
        {
            return "{Resultado de Windows Button}";           
        }
    }
}
