using ATM_Simulation.Entities;
using ATM_Simulation.Services;

namespace ATM_Simulation
{
    public class Programa
    {
        static void Main(string[] args)
        {
            List<Usuario> usuarios = new List<Usuario>
            {
                new Usuario("Juan Pérez", "1234", "1010"),
                new Usuario("María García", "5678", "2001"),
                new Usuario("Luis Martínez", "9876", "3050"),
                new Usuario("Ana González", "5432", "4098"),
                new Usuario("Carlos Sánchez", "6789", "5123")
            };

            CajeroAutomatico cajeroAutomatico = new CajeroAutomatico(usuarios);
            cajeroAutomatico.Iniciar();
        }
    }
}
