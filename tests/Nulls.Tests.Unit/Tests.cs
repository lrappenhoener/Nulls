using System;
using FluentAssertions;
using Xunit;

namespace Nulls.Tests.Unit
{
    public class Tests
    {

        [Fact]
        public void Value_When_Some_String_Should_Return_Expected_String()
        {
            var expected = "some string";

            var sut = Maybe.Some(expected);

            sut.Value.Should().Be(expected);
        }

        [Fact]
        public void Value_When_Some_Integer_Should_Return_Expected_Integer()
        {
            var expected = 42;

            var sut = Maybe.Some(expected);

            sut.Value.Should().Be(expected);
        }

        [Fact]
        public void Value_When_Some_CustomObject_Should_Return_Expected_CustomObject()
        {
            var expected = new CustomObject();

            var sut = Maybe.Some(expected);

            sut.Value.Should().Be(expected);
        }


        [Fact]
        public void HasValue_When_Some_CustomObject_Should_Return_True()
        {
            var expected = new CustomObject();

            var sut = Maybe.Some(expected);

            sut.HasValue.Should().BeTrue();
        }

        [Fact]
        public void HasValue_When_Some_String_Should_Return_True()
        {
            var expected = "some string";

            var sut = Maybe.Some(expected);

            sut.HasValue.Should().BeTrue();
        }

        [Fact]
        public void HasValue_When_Some_Integer_Should_Return_True()
        {
            var expected = 42;

            var sut = Maybe.Some(expected);

            sut.HasValue.Should().BeTrue();
        }

        [Fact]
        public void HasValue_When_None_CustomObject_Should_Return_False()
        {
            var sut = Maybe.None<CustomObject>();

            sut.HasValue.Should().BeFalse();
        }

        [Fact]
        public void HasValue_When_None_String_Should_Return_False()
        {
            var sut = Maybe.None<string>();

            sut.HasValue.Should().BeFalse();
        }

        [Fact]
        public void HasValue_When_None_Integer_Should_Return_False()
        {
            var sut = Maybe.None<int>();

            sut.HasValue.Should().BeFalse();
        }

        [Fact]
        public void Value_When_None_CustomObject_Should_Throw_InvalidOperationException()
        {
            var sut = Maybe.None<CustomObject>();

            Assert.Throws<InvalidOperationException>(() => sut.Value);
        }

        [Fact]
        public void Value_When_None_String_Should_Throw_InvalidOperationException()
        {
            var sut = Maybe.None<string>();

            Assert.Throws<InvalidOperationException>(() => sut.Value);
        }

        [Fact]
        public void Value_When_None_Integer_Should_Throw_InvalidOperationException()
        {
            var sut = Maybe.None<int>();

            Assert.Throws<InvalidOperationException>(() => sut.Value);
        }
    }

    internal class CustomObject { }
}
