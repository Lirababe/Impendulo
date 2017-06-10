using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Impendulo.Common.EmailSending
{
    public abstract class EmailAttachment : IAttachment
    {
        private string _AttachmentFileExtension = "";
        private string _AttachmentFileName = "";
        private string _AttachemntPath = "";
        public string AttachmentFileExtension
        {
            get
            {
                return _AttachmentFileExtension;
            }

            set
            {
                _AttachmentFileExtension = value;
            }
        }

        public string AttachmentFileName
        {
            get
            {
                return _AttachmentFileName;
            }

            set
            {
                _AttachmentFileName = value;
            }
        }

        public string AttachmentFullFileName
        {
            get
            {
                return this._AttachmentFileName + "." + this._AttachmentFileExtension;
            }
        }

        public string AttachemntPath
        {
            get
            {
                return _AttachemntPath;
            }

            set
            {
                if (System.IO.Directory.Exists(value))
                {

                }
                _AttachemntPath = value;
            }
        }

        public abstract void GetAttachment();
    }
}