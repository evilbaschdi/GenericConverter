namespace GenericConverter.Tests;

public class DoubleFromStringTests
{
    [Theory, NSubstituteOmitAutoPropertiesTrueAutoData]
    public void Constructor_HasNullGuards(GuardClauseAssertion assertion)
    {
        assertion.Verify(typeof(DoubleFromString).GetConstructors());
    }

    [Theory, NSubstituteOmitAutoPropertiesTrueAutoData]
    public void Constructor_ReturnsInterfaceName(DoubleFromString sut)
    {
        sut.Should().BeAssignableTo<ConvertFromString>();
    }

    //[Theory, NSubstituteOmitAutoPropertiesTrueAutoData]
    //public void Methods_HaveNullGuards(GuardClauseAssertion assertion)
    //{
    //    assertion.Verify(typeof(DoubleFromString).GetMethods().Where(method => !method.IsAbstract));
    //}
}