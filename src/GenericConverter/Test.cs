using System;
using GenericConverter.Internal;

namespace GenericConverter
{
    public class Test : ITest
    {
        private readonly IConvertFromString _convertFromString;

        /// <summary>Initialisiert eine neue Instanz der <see cref="T:System.Object" />-Klasse.</summary>
        /// <exception cref="ArgumentNullException"><paramref name="convertFromString" /> is <see langword="null" />.</exception>
        public Test(IConvertFromString convertFromString)
        {
            if (convertFromString == null)
            {
                throw new ArgumentNullException(nameof(convertFromString));
            }
            _convertFromString = convertFromString;
        }

        public void Run()
        {
            var input = "1";

            //todo: null and emtpy string validation.
            //todo: providing format

            var output = _convertFromString.Output(input, typeof(decimal));

            Console.WriteLine(output.GetType());
            Console.WriteLine(output);
        }
    }
}