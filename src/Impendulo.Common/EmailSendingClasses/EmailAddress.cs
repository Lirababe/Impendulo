using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Impendulo.Common.EmailSending
{
    public class EmailAddress : RegexUtilities, IEmailAddress
    {
        public string Address { get; set; }
        public EmailAddress(string strEmailAddress)
        {
            if (ValidateEmailAddress(strEmailAddress))
            {
                Address = strEmailAddress;
            }
            else
            {
                throw new InvalidEmailAddressException("The Following Address is Invalid: " + strEmailAddress + ", Address Not Added.");
            }
        }
        public Boolean ValidateEmailAddress(string strEmailAddress)
        {
            return base.IsValidEmail(strEmailAddress);
        }
    }
}