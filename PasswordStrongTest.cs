using System;
using Xunit;

namespace PasswordStrong
{
    public class PasswordStrongTest
    {
        [Fact]
        public void Input_1234_Should_Be_Display_False()
        {
            string input = "1234";

            PasswordStrong passwordStrong = new PasswordStrong();
            bool actual = passwordStrong.CheckCondition(input);

            Assert.False(actual);
        }
    }
}
