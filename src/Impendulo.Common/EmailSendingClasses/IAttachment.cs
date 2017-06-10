using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Impendulo.Common.EmailSending
{
    public interface IAttachment
    {
        string AttachmentFullFileName { get; }
        string AttachmentFileName { get; set; }
        string AttachmentFileExtension { get; set; }
        string AttachemntPath { get; set; }
    }
}