using System;

namespace GenericConverter.TestConsole
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var compositionRoot = new CompositionRoot();
            compositionRoot.Run();
            Console.ReadLine();
        }
    }
}