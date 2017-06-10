using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Impendulo.Common.EmailSending
{
    public interface IMessage
    {

        enumMessagePriority MessagePriority { get; set; }
        string MessageBody { get; set; }
    }
}