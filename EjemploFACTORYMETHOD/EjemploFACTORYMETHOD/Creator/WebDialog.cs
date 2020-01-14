using EjemploFACTORYMETHOD.Interfaces;

namespace EjemploFACTORYMETHOD.Creator
{
    class WebDialog : Creador
    {
        public override IButton FactoryMethod()
        {
            return new HTMLButton();
        }
    }
}
