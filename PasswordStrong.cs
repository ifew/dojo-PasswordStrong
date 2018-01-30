using System;

namespace PasswordStrong
{
    public class PasswordStrong
    {
        public bool CheckCondition(string input)
        {
            bool intValid = false;
            bool stringValid = false;
            var charInput = input.ToCharArray();

            if(charInput.Length >= 8) {
                for(int lenght=0; lenght < charInput.Length; lenght++ ) {
                    if(Char.IsDigit(charInput[0])) {
                        return false;
                    }
                    
                    if(Char.IsLetter(charInput[lenght])) {
                        stringValid = true;
                    }

                    intValid = CharIsDigit(charInput[lenght]);

                    if(intValid && stringValid) {
                        return true;
                    }
                }
            }

            return false;
        }

        public bool CharIsDigit(char input) {
            if(Char.IsDigit(input)) {
                return true;
            }
        
            return false;
        }
    }
}
