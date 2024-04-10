using ATM_Simulation.Entities;

namespace ATM_Simulation.Services
{
    public class CajeroAutomatico
    {
        private readonly List<Usuario> _usuarios;

        public CajeroAutomatico(List<Usuario> usuarios)
        {
            _usuarios = usuarios;
        }

        public void Iniciar()
        {
            Console.WriteLine("Bienvenido al Cajero Automático");

            while (true)
            {
                Console.Write("Ingrese su tarjeta: ");
                string numeroTarjeta = Console.ReadLine();

                Console.Write("Ingrese su PIN: ");
                string pin = Console.ReadLine();

                Usuario usuarioActual = AutenticarUsuario(numeroTarjeta, pin);

                if (usuarioActual != null)
                {
                    Console.WriteLine($"¡Bienvenido, {usuarioActual.Nombre}!");
                    MostrarMenu(usuarioActual);
                }
                else
                {
                    Console.WriteLine("Tarjeta o PIN incorrecto. Por favor, inténtelo de nuevo.");
                }
            }
        }

        private Usuario AutenticarUsuario(string numeroTarjeta, string pin)
        {
            foreach (var usuario in _usuarios)
            {
                if (usuario.Tarjeta.NumeroTarjeta == numeroTarjeta && usuario.Tarjeta.Pin == pin)
                {
                    return usuario;
                }
            }
            return null;
        }

        private void MostrarMenu(Usuario usuario)
        {
            Menu menu = new Menu(usuario);
            menu.Mostrar();
        }
    }
}
