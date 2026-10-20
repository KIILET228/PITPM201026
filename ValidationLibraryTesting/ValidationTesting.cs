using ValidationLibrary;
using FluentAssertions;

namespace ValidationLibraryTesting
{
    // 1
    public class ValidationTesting
    {
        [Fact]
        public void CorrectInputTest()
        {
            string password = "password1";
            Validation.ValidatePassword(password).Should().BeTrue();
        }

        [Fact]
        public void IncorrectInputLengthTest()
        {
            string password = "p";
            Validation.ValidatePassword(password).Should().BeFalse();
        }

        [Fact]
        public void IncorrectInputLengthEmptyTest()
        {
            string password = "";
            Validation.ValidatePassword(password).Should().BeFalse();
        }

        [Fact]
        public void IncorrectInputLengthNullTest()
        {
            string? password = null;
            Validation.ValidatePassword(password).Should().BeFalse();
        }

        [Fact]
        public void IncorrectInputDigitTest()
        {
            string password = "password";
            Validation.ValidatePassword(password).Should().BeFalse();
        }

        [Fact]
        public void IncorrectInputLatinTest()
        {
            string password = "Сырные чебуреки осенью в 6 утра выходят на пробежку с сушеной селедкой";
            Validation.ValidatePassword(password).Should().BeFalse();
        }
    }
}
