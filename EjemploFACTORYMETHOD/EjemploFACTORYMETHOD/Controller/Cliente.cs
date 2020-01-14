using EjemploFACTORYMETHOD.Creator;
using System;

namespace EjemploFACTORYMETHOD.Controller
{
    class Cliente
    {
        public void Main()
        {
            Console.WriteLine("Applicación: Lanzado con el WindowsDialog ");
            ClienteCode( new WindowsDialog());

            Console.WriteLine("");

            Console.WriteLine("Aplicación: Lanzado desde la WebDialog");
            ClienteCode(new WebDialog());

        }

        // El código del cliente funciona con una instancia de un creador concreto, aunque
        // a través de su interfaz base. Mientras el cliente siga trabajando con
        // el creador a través de la interfaz base, puede pasarlo de cualquier creador
        // subclase.
        public void ClienteCode(Creador creador)
        {            
            Console.WriteLine("Cliente: No conozco la clase del creador, " +
                "pero aún funciona.\n" + creador.SomeOperation());
        }
    }
}
