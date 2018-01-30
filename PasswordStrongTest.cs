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

        [Fact]
        public void Input_12abc_Should_Be_Display_False()
        {
            string input = "12abc";

            PasswordStrong passwordStrong = new PasswordStrong();
            bool actual = passwordStrong.CheckCondition(input);

            Assert.False(actual);
        }


        [Fact]
        public void Input_12345678_Should_Be_Display_True()
        {
            string input = "12345678";

            PasswordStrong passwordStrong = new PasswordStrong();
            bool actual = passwordStrong.CheckCondition(input);

            Assert.False(actual);
        }
        
        [Fact]
        public void Input_abcdefgh_Should_Be_Display_True()
        {
            string input = "abcdefgh";

            PasswordStrong passwordStrong = new PasswordStrong();
            bool actual = passwordStrong.CheckCondition(input);

            Assert.False(actual);
        }
        
        [Fact]
        public void Input_12ab34cd_Should_Be_Display_True()
        {
            string input = "12ab34cd";

            PasswordStrong passwordStrong = new PasswordStrong();
            bool actual = passwordStrong.CheckCondition(input);

            Assert.False(actual);
        }
        
        [Fact]
        public void Input_ab12cd45_Should_Be_Display_True()
        {
            string input = "ab12cd45";

            PasswordStrong passwordStrong = new PasswordStrong();
            bool actual = passwordStrong.CheckCondition(input);

            Assert.True(actual);
        }

        [Fact]
        public void Input_ab12cd45ef_Should_Be_Display_True()
        {
            string input = "ab12cd45ef";

            PasswordStrong passwordStrong = new PasswordStrong();
            bool actual = passwordStrong.CheckCondition(input);

            Assert.True(actual);
        }
    }
}
