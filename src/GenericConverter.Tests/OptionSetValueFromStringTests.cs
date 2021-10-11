using Xunit;
using System.Linq;
using AutoFixture.Idioms;
using EvilBaschdi.Testing;
using FluentAssertions;

namespace GenericConverter.Tests
{
    public class OptionSetValueFromStringTests
    {
        [Theory, NSubstituteOmitAutoPropertiesTrueAutoData]
        public void Constructor_HasNullGuards(GuardClauseAssertion assertion)
        {
            assertion.Verify(typeof(OptionSetValueFromString).GetConstructors());
        }

        [Theory, NSubstituteOmitAutoPropertiesTrueAutoData]
        public void Constructor_ReturnsInterfaceName(OptionSetValueFromString sut)
        {
            sut.Should().BeAssignableTo<ConvertFromString>();
        }

        [Theory, NSubstituteOmitAutoPropertiesTrueAutoData]
        public void Methods_HaveNullGuards(GuardClauseAssertion assertion)
        {
            assertion.Verify(typeof(OptionSetValueFromString).GetMethods().Where(method => !method.IsAbstract));
        }


    }
}