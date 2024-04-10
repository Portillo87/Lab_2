namespace ATM_Simulation.Entities
{
    public class Tarjeta
    {
        public string NumeroTarjeta { get; }
        public string Pin { get; }

        public Tarjeta(string numeroTarjeta, string pin)
        {
            NumeroTarjeta = numeroTarjeta;
            Pin = pin;
        }
    }
}
