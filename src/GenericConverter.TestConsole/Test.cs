using Microsoft.Xrm.Sdk.Metadata;

namespace GenericConverter.TestConsole
{
    public class Test : ITest
    {
        private readonly IConvertFromString _convertFromString;

        /// <summary>Initialisiert eine neue Instanz der <see cref="T:System.Object" />-Klasse.</summary>
        /// <exception cref="ArgumentNullException"><paramref name="convertFromString" /> is <see langword="null" />.</exception>
        public Test(IConvertFromString convertFromString)
        {
            _convertFromString = convertFromString ?? throw new ArgumentNullException(nameof(convertFromString));
        }

        public void Run()
        {
            var input = "1";

            //todo: null and empty string validation.
            //todo: providing format

            var output = _convertFromString.Output(input, AttributeTypeCode.Decimal);

            Console.WriteLine(output.GetType());
            Console.WriteLine(output);
        }
    }
}