using System;

namespace Design_Patterns.Abstract_Factory
{
    public class NewZelandForestFactory : AnimalFactory
    {
        public override Reptile CreateReptile() => new Tautara();

        public override Insect CreateInsect() => new Katipo();
    }

    public class Tautara : Reptile
    {
        public override void Eat(Insect insect)
        {
            Console.WriteLine($"Eat {insect.GetType().Name}");
        }
    }

    public class Katipo : Insect
    {

    }

}
