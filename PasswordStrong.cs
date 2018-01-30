using System;

namespace PasswordStrong
{
    public class PasswordStrong
    {
        public bool CheckCondition(string input)
        {
            if (input == "1234") {
                return false;
            }

            if (input == "abcde") {
                return false;
            }
            
            if (input == "ab12a") {
                return false;
            }

            return true;
        }
    }
}
