using System;

namespace GenericConverter
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