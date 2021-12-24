namespace Design_Patterns.Abstract_Factory
{
    public class BrazilForestFactory : AnimalFactory
    {
        public override Reptile CreateReptile()
        {
            throw new System.NotImplementedException();
        }

        public override Insect CreateInsect()
        {
            throw new System.NotImplementedException();
        }
    }


}
