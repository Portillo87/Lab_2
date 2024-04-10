namespace ATM_Simulation.Entities
{
    public class Usuario
    {
        public string Nombre { get; }
        public Tarjeta Tarjeta { get; }
        public decimal Saldo { get; set; }

        public Usuario(string nombre, string numeroTarjeta, string pin)
        {
            Nombre = nombre;
            Tarjeta = new Tarjeta(numeroTarjeta, pin);
            Saldo = 0;
        }
    }
}
