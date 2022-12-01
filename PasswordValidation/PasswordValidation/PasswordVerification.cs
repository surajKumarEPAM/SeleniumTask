using System;
namespace PasswordValidation
{
    public class PasswordVerification
    {
        public String password;

        public string IsValidPassword()
        {
            if (password.Length >= 8 && password.Length <= 12)
                return "This is a valid password";
            else
                return "This is a invalid password";
        }

    }
}