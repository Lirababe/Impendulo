using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Impendulo.Email
{
    public class EmailAddress : RegexUtilities, IEmailAddress
    {
        string Address { get; set; }
        public EmailAddress(string strEmailAddress)
        {
            if (ValidateEmailAddress(strEmailAddress))
            {
                Address = strEmailAddress;
            }
            else
            {
                //Through Invalid Email Exception
            }
        }
        public Boolean ValidateEmailAddress(string strEmailAddress)
        {
            return IsValidEmail(strEmailAddress);
        }
    }
}