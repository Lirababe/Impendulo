﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Impendulo.Email.EmailSendingClasses
{
    public interface IEmailMessage : IMessage
    {
        List<IEmailAddress> ToAddesses { get; }
        List<IEmailAddress> CcAddresses { get; }
        List<IEmailAddress> BccAddress { get; }
        List<IAttachment> Attachments { get; }
        string FromAddress { get; }
        /// <summary>
        /// 
        /// </summary>
        void sendMessage();
    }
}
