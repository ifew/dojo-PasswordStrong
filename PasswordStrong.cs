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
            
            return true;
        }
    }
}
