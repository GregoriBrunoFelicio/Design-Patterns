namespace Design_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var singleton = Singleton.GetInstance();
            var x = Singleton.GetInstance();
        }
    }
}
