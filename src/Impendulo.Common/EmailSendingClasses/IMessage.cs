using Impendulo.Email.EmailSendingClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Impendulo.Common.EmailSendingClasses
{
    public interface IMessage
    {

        enumMessagePriority MessagePriority { get; set; }
        string MessageBody { get; set; }
    }
}