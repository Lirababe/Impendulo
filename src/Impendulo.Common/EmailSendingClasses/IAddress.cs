using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Impendulo.Common.EmailSending
{
    public interface IEmailAddress
    {
        Boolean ValidateEmailAddress(string strEmailAddress);
    }
}