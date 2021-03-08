using GenericConverter;
using NSubstitute;
using System;
using Xunit;
using System.Linq;
using AutoFixture.Idioms;
using EvilBaschdi.Testing;
using FluentAssertions;

namespace GenericConverter.Tests
{
    public class Int32FromStringTests
    {
        [Theory, NSubstituteOmitAutoPropertiesTrueAutoData]
        public void Constructor_HasNullGuards(GuardClauseAssertion assertion)
        {
            assertion.Verify(typeof(Int32FromString).GetConstructors());
        }

        [Theory, NSubstituteOmitAutoPropertiesTrueAutoData]
        public void Constructor_ReturnsInterfaceName(Int32FromString sut)
        {
            sut.Should().BeAssignableTo<ConvertFromString>();
        }

        [Theory, NSubstituteOmitAutoPropertiesTrueAutoData]
        public void Methods_HaveNullGuards(GuardClauseAssertion assertion)
        {
            assertion.Verify(typeof(Int32FromString).GetMethods().Where(method => !method.IsAbstract));
        }


    }
}