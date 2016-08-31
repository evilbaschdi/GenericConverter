using GenericConverter.Internal;

namespace GenericConverter
{
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
}