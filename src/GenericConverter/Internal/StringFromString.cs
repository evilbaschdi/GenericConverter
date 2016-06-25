namespace GenericConverter.Internal
{
    public class StringFromString : ConvertFromString
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="T:System.Object" /> class.
        /// </summary>
        public StringFromString(IConvertFromString convertFromString)
            : base(convertFromString)
        {
            //if (convertFromString == null)
            //{
            //    throw new ArgumentNullException(nameof(convertFromString));
            //}
        }

        public override bool AmIResponsible => OutputType.Name == "String";

        public override object InnerOutput(string input)
        {
            return input;
        }
    }
}