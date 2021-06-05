namespace Design_Patterns
{
    public class Singleton
    {
        private static object instance = null;
        private Singleton()
        {

        }

        public static object GetInstance()
        {
            return instance == null ? new Singleton() : instance;
        }
    }
}
