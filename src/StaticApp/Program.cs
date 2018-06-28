using Tutorial.Singletion;

namespace StaticApp
{
    class Program
    {
        static void Main(string[] args)
        {

            SingletonContext context = SingletonContext.ContextInstance;
            // Multi threat
            SingletonContext contextMulid = SingletonContext.ContextMultiThreatInstance;
        }
    }
}
