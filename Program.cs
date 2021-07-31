using System;

namespace Design_Patterns
{
    class Program
    {
        static void Main()
        {
            var calculo = new Calculo(new Cliente3());
            calculo.Calcular(45);
        }
    }

    interface ICalculo
    {
        void Calcular(int valor);
    }

    class Calculo : ICalculo
    {
        private readonly ICalculo calculo;

        public Calculo(ICalculo calculo) => this.calculo = calculo;

        public void Calcular(int valor)
        {
            calculo.Calcular(valor);
        }
    }

    public abstract class Cliente
    {
        public string Nome { get; set; }
    }

    public class Cliente1 : ICalculo
    {
        public void Calcular(int valor)
        {
            Console.WriteLine(2 + valor);
        }
    }

    public class Cliente2 : ICalculo
    {
        public void Calcular(int valor)
        {
            Console.WriteLine(3 + valor);
        }
    }

    public class Cliente3 : ICalculo
    {
        public void Calcular(int valor)
        {
            Console.WriteLine(4 + valor);
        }
    }
}
