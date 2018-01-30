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
        
        [Fact]
        public void Input_abcde_Should_Be_Display_False()
        {
            string input = "abcde";

            PasswordStrong passwordStrong = new PasswordStrong();
            bool actual = passwordStrong.CheckCondition(input);

            Assert.False(actual);
        }

        [Fact]
        public void Input_ab12a_Should_Be_Display_False()
        {
            string input = "ab12a";

            PasswordStrong passwordStrong = new PasswordStrong();
            bool actual = passwordStrong.CheckCondition(input);

            Assert.False(actual);
        }
    }
}
