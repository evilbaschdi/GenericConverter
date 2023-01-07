namespace GenericConverter.Tests;

public class GuidFromStringTests
{
    [Theory, NSubstituteOmitAutoPropertiesTrueAutoData]
    public void Constructor_HasNullGuards(GuardClauseAssertion assertion)
    {
        assertion.Verify(typeof(GuidFromString).GetConstructors());
    }

    [Theory, NSubstituteOmitAutoPropertiesTrueAutoData]
    public void Constructor_ReturnsInterfaceName(GuidFromString sut)
    {
        sut.Should().BeAssignableTo<ConvertFromString>();
    }

    //[Theory, NSubstituteOmitAutoPropertiesTrueAutoData]
    //public void Methods_HaveNullGuards(GuardClauseAssertion assertion)
    //{
    //    assertion.Verify(typeof(GuidFromString).GetMethods().Where(method => !method.IsAbstract));
    //}
}