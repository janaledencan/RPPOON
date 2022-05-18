using System;
using System.Collections.Generic;
using System.Text;

/*Napisati klasu PasswordValidator koja se koristiti lancem odgovornosti iz zadatka 6 za provjeru valjanosti
lozinke. Klasa treba pružiti metodu za dodavanje karika u lanac, a preko konstruktora joj se daje samo prva
u redu.*/

namespace ChainOfResponsibility
{
    class PasswordValidator
    {
        StringChecker stringChecker;

        public PasswordValidator(StringChecker stringChecker)
        {
            this.stringChecker = stringChecker;
        }

        public void SetNext(StringChecker nextChecker)
        {
            stringChecker.SetNext(nextChecker);
        }

        public bool ValidatePassword(string pasword)
        {
            if (stringChecker.Check(pasword))
            {
                return true;
            }
            return false;
        }
    }
}
