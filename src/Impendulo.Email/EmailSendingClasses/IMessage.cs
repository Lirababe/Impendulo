using Impendulo.Email.EmailSendingClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Impendulo.Email
{
    public interface IMessage
    {
       
        string MessageBody { get; set; }
    }
}