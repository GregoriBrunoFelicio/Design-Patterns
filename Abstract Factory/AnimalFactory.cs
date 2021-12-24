namespace Design_Patterns.Abstract_Factory
{
    public abstract class AnimalFactory
    {
        public abstract Reptile CreateReptile();
        public abstract Insect CreateInsect();
    }
}
