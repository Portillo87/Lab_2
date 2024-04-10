using ATM_Simulation.Entities;

namespace ATM_Simulation.Services
{
    public class Menu
    {
        private readonly Usuario _usuario;

        public Menu(Usuario usuario)
        {
            _usuario = usuario;
        }

        public void Mostrar()
        {
            Console.WriteLine("\nMenú Principal:");
            Console.WriteLine("1. Ver Saldo");
            Console.WriteLine("2. Hacer un Retiro");
            Console.WriteLine("3. Hacer un Depósito");
            Console.WriteLine("4. Pagar Facturas");
            Console.WriteLine("5. Cambiar PIN");
            Console.WriteLine("6. Salir");

            Console.Write("Seleccione una opción: ");
            if (!int.TryParse(Console.ReadLine(), out int eleccion))
            {
                Console.WriteLine("Opción no válida. Por favor, seleccione un número del 1 al 6.");
                return;
            }

            switch (eleccion)
            {
                case 1:
                    Console.WriteLine($"Su saldo actual es: {_usuario.Saldo:C}");
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    Console.WriteLine("Gracias por utilizar nuestro servicio. ¡Hasta luego!");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opción no válida. Por favor, seleccione una opción del 1 al 6.");
                    break;
            }
        }
    }
}
