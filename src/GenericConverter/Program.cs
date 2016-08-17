using System;
using GenericConverter.Internal;

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

    public class CompositionRoot
    {
        public void Run()
        {
            IConvertFromString defaultConverter = new StringFromString(null);
            IConvertFromString optionSetValue = new OptionSetValueFromString(defaultConverter);
            IConvertFromString moneyFromString = new MoneyFromString(optionSetValue);
            IConvertFromString int32FromString = new Int32FromString(moneyFromString);
            IConvertFromString guidFromString = new GuidFromString(int32FromString);
            IConvertFromString doubleFromString = new DoubleFromString(guidFromString);
            IConvertFromString decimalFromString = new DecimalFromString(doubleFromString);
            IConvertFromString dateTimeFromString = new DateTimeFromString(decimalFromString);
            IConvertFromString boolFromString = new BoolFromString(dateTimeFromString);
            ITest test = new Test(boolFromString);
            test.Run();
        }
    }

    public class Test : ITest
    {
        private readonly IConvertFromString _convertFromString;

        /// <summary>Initialisiert eine neue Instanz der <see cref="T:System.Object" />-Klasse.</summary>
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

            //var entity = new Entity();
            //entity.Attributes.Add("test", new decimal(5));

            //var test = entity["test"];

            var output = _convertFromString.Output(input, typeof(decimal));

            Console.WriteLine(output.GetType());
            Console.WriteLine(output);
        }
    }

    public interface ITest
    {
        void Run();
    }
}