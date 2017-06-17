using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Impendulo.Common.EmailSending
{
    public class FileBasedEmailAttachment : EmailAttachment
    {
        public FileBasedEmailAttachment()
        {
            // this.AttachemntPath = "C:/MCDAttachemntsTemp";
            this.GetAttachment();
        }
        public FileBasedEmailAttachment(string FileName)
        {
            // this.AttachemntPath = "C:\\MCDAttachemntsTemp";
            FileInfo fileInfo = new FileInfo(FileName);

            Char delimiter = '.';
            AttachmentFileName = fileInfo.Name.Split(delimiter)[0];
            AttachmentFileExtension = fileInfo.Extension.Replace(".", "");

        }
        public override void GetAttachment()
        {
            OpenFileDialog openFileDialogOpenFiles = new OpenFileDialog();
            openFileDialogOpenFiles.Multiselect = false;
            openFileDialogOpenFiles.ShowDialog();
            if (openFileDialogOpenFiles.FileNames.Count() > 0)
            {
                foreach (string LocalFileName in openFileDialogOpenFiles.FileNames)
                {
                    FileInfo fileInfo = new FileInfo(LocalFileName);

                    Char delimiter = '.';
                    AttachmentFileName = fileInfo.Name.Split(delimiter)[0];
                    AttachmentFileExtension = fileInfo.Extension.Replace(".", "");
                    this.AttachemntPath = LocalFileName;

                }
            }
            else
            {
                AttachmentFileName = "";
                AttachmentFileExtension = "";
                this.AttachemntPath = "";
            }
        }
    }
}