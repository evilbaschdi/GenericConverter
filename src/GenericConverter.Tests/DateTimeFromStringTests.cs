namespace GenericConverter.Tests;

public class DateTimeFromStringTests
{
    [Theory, NSubstituteOmitAutoPropertiesTrueAutoData]
    public void Constructor_HasNullGuards(GuardClauseAssertion assertion)
    {
        assertion.Verify(typeof(DateTimeFromString).GetConstructors());
    }

    [Theory, NSubstituteOmitAutoPropertiesTrueAutoData]
    public void Constructor_ReturnsInterfaceName(DateTimeFromString sut)
    {
        sut.Should().BeAssignableTo<ConvertFromString>();
    }

    //[Theory, NSubstituteOmitAutoPropertiesTrueAutoData]
    //public void Methods_HaveNullGuards(GuardClauseAssertion assertion)
    //{
    //    assertion.Verify(typeof(DateTimeFromString).GetMethods().Where(method => !method.IsAbstract));
    //}
}