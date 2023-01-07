namespace GenericConverter.Tests;

public class BoolFromStringTests
{
    [Theory, NSubstituteOmitAutoPropertiesTrueAutoData]
    public void Constructor_HasNullGuards(GuardClauseAssertion assertion)
    {
        assertion.Verify(typeof(BoolFromString).GetConstructors());
    }

    [Theory, NSubstituteOmitAutoPropertiesTrueAutoData]
    public void Constructor_ReturnsInterfaceName(BoolFromString sut)
    {
        sut.Should().BeAssignableTo<ConvertFromString>();
    }

    //[Theory, NSubstituteOmitAutoPropertiesTrueAutoData]
    //public void Methods_HaveNullGuards(GuardClauseAssertion assertion)
    //{
    //    assertion.Verify(typeof(BoolFromString).GetMethods().Where(method => !method.IsAbstract));
    //}
}