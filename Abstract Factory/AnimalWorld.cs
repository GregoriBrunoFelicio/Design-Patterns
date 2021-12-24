namespace Design_Patterns.Abstract_Factory
{
    public class AnimalWorld
    {
        private Insect insect;
        private Reptile reptile;

        public AnimalWorld(AnimalFactory animalFactory)
        {
            insect = animalFactory.CreateInsect();
            reptile = animalFactory.CreateReptile();
        }

        public void FoodChain()
        {
            reptile.Eat(insect);
        }
    }
}
