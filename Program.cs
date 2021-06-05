using System;

namespace Design_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var pedido = new Pedido
            {
                Total = 10
            };

            var banco = new Itau();

            var calculadoraDeJuros = new CalculadorDeJuros(banco);

            Console.WriteLine(calculadoraDeJuros.CalcularJuros(pedido));
        }
    }
}
