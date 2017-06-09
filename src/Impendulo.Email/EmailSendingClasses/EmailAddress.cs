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
                throw new InvalidEmailAddressException("The Following Address is In valid: " + strEmailAddress);
            }
        }
        public Boolean ValidateEmailAddress(string strEmailAddress)
        {
            return IsValidEmail(strEmailAddress);
        }
    }
}