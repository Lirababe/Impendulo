using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Impendulo.Email.EmailSendingClasses
{
    public interface IEmailMessage : IMessage
    {
        List<IEmailAddress> ToAddesses { get; set; }
        List<IEmailAddress> CCAddresses { get; set; }
        List<IEmailAddress> BCCAddress { get; set; }
        IEmailAddress FromAddress { get; set; }
        /// <summary>
        /// 
        /// </summary>
        void sendMessage();
    }
}
