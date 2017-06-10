using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Impendulo.Common.EmailSendingClasses
{
    public interface IEmailAddress
    {
        Boolean ValidateEmailAddress(string strEmailAddress);
    }
}