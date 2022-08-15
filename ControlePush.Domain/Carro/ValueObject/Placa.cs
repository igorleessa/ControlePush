namespace ControlePush.Domain.Carro.ValueObject
{
    public class Placa
    {
        public Placa()
        {

        }

        public Placa(string placa)
        {
            this.Valor = placa ?? throw new ArgumentNullException(nameof(placa));
        }

        public string Valor { get; set; }
    }
}
