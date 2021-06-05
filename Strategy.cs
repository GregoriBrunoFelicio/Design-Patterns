namespace Design_Patterns
{
    public class Pedido
    {
        public decimal Total { get; set; }
    }

    public class Bradesco : CalculoDeJuros
    {
        public decimal CalcularJuros(object obj)
        {
            var pedido = obj as Pedido;
            return pedido.Total * 5;
        }
    }

    public class Itau : CalculoDeJuros
    {
        public decimal CalcularJuros(object obj)
        {
            var pedido = obj as Pedido;
            return pedido.Total * 10;
        }
    }

    public interface CalculoDeJuros
    {
        decimal CalcularJuros(object obj);
    }

    public class CalculadorDeJuros
    {
        private readonly CalculoDeJuros calculoDeJuros;

        public CalculadorDeJuros(CalculoDeJuros calculoDeJuros)
        {
            this.calculoDeJuros = calculoDeJuros;
        }

        public decimal CalcularJuros(object obj)
        {
            var pedido = obj as Pedido;
            return this.calculoDeJuros.CalcularJuros(pedido);

        }
    }
}
