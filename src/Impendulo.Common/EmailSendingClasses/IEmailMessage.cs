using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Impendulo.Common.EmailSending
{
    public interface IEmailMessage : IMessage
    {
        List<IEmailAddress> ToAddesses { get; }
        List<IEmailAddress> CcAddresses { get; }
        List<IEmailAddress> BccAddress { get; }
        List<IAttachment> Attachments { get; }
        string Subject { get; set; }
        string FromAddress { get; }
        string DisplayName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        void SendMessage();
    }
}
