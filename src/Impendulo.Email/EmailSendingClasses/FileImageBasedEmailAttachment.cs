﻿using Impendulo.Data.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Impendulo.Email
{
    public class FileImageBasedEmailAttachment : EmailAttachment
    {
        public int FileID { get; }
        public FileImageBasedEmailAttachment(int FileID)
        {
            this.AttachemntPath = "C:\\MCDAttachemntsTemp";
            this.FileID = FileID;
        }

        public override void GetAttachment()
        {
            if (checkTempFolderExists())
            {
                Data.Models.File CurrentFile = Common.FileHandeling.FileHandeling.GetFile(this.FileID);

                this.AttachmentFileName = CurrentFile.FileName;
                this.AttachmentFileExtension = CurrentFile.FileExtension;
               

                System.IO.File.WriteAllBytes(AttachemntPath + "\\" + this.FileID.ToString() + "_" + this.AttachmentFullFileName, CurrentFile.FileImage);
            }
        }
        public Boolean ClearCreateTempDirectory()
        {
            Boolean Rtn = false;
            try
            {
                if (System.IO.Directory.Exists("C:\\MCDAttachemntsTemp"))
                {
                    DirectoryInfo directory = new DirectoryInfo("C:\\MCDAttachemntsTemp");

                    //delete files:
                    directory.GetFiles().ToList().ForEach(f => f.Delete());

                    //delete folders inside choosen folder
                    directory.GetDirectories().ToList().ForEach(d => d.Delete(true));
                    Rtn = true;
                }
                else
                {
                    Directory.CreateDirectory("C:\\MCDAttachemntsTemp");
                    Rtn = true;
                }
            }
            catch (Exception ex)
            {
                Rtn = false;
                System.Windows.Forms.MessageBox.Show("Error clearing or Creating Temp Folder for Attachments" + ": " + ex.Message.ToString(), "Attachment Temp Folder Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }

            return Rtn;
        }

        private Boolean checkTempFolderExists()
        {
            Boolean Rtn = false;
            try
            {
                if (System.IO.Directory.Exists("C:\\MCDAttachemntsTemp"))
                {
                    DirectoryInfo directory = new DirectoryInfo("C:\\MCDAttachemntsTemp");
                    Rtn = true;
                }
                else
                {
                    Directory.CreateDirectory("C:\\MCDAttachemntsTemp");
                    Rtn = true;
                }
            }
            catch (Exception ex)
            {
                Rtn = false;
                System.Windows.Forms.MessageBox.Show("Error Clearing or Creating Temp Folder for Attachments" + ": " + ex.Message.ToString(), "Attachment Temp Folder Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }

            return Rtn;
        }


    }
}