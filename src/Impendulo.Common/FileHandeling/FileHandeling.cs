using System;
using System.Collections.Generic;
using System.Linq;

using Impendulo.Data.Models;
using System.Windows.Forms;
using System.IO;

namespace Impendulo.Common.FileHandeling
{

    public static class FileHandeling
    {

        private static FileStream fs;
        private static BinaryReader br;
        // private static OpenFileDialog openFileDialogOpenFiles { get; set; }
        // public static Impendulo.Data.Models.File[] CurrentlyUploadedFiles { get; set; }

        public static List<Impendulo.Data.Models.File> UploadFile(Boolean UseMultipleFileSelect = true, Boolean AutomaicallyAddFileToDatabase = true, Boolean ImagesOnly = false)
        {

            List<Impendulo.Data.Models.File> CurrentlyUploadedFiles = new List<Impendulo.Data.Models.File>();
            OpenFileDialog openFileDialogOpenFiles = new OpenFileDialog();
            openFileDialogOpenFiles.Multiselect = UseMultipleFileSelect;
            if (ImagesOnly)
            {
                openFileDialogOpenFiles.Filter = "Image Files(*.BMP; *.JPG; *.GIF, *.PNG)| *.BMP; *.JPG; *.GIF; *.PNG";
            }
            openFileDialogOpenFiles.ShowDialog();
            if (openFileDialogOpenFiles.FileNames.Count() > 0)
            {
                foreach (string LocalFileName in openFileDialogOpenFiles.FileNames)
                {

                    FileInfo fileInfo = new FileInfo(LocalFileName);

                    Byte[] fileToUpload = new Byte[Convert.ToInt32(fileInfo.Length)];

                    try
                    {

                        fs = new FileStream(LocalFileName, FileMode.Open, FileAccess.Read);
                        br = new BinaryReader(fs);
                        fileToUpload = br.ReadBytes(Convert.ToInt32(fileInfo.Length));

                        Char delimiter = '.';
                        var newFile = new Impendulo.Data.Models.File
                        {
                            FileName = fileInfo.Name.Split(delimiter)[0],
                            FileExtension = fileInfo.Extension.Replace(".", ""),
                            ContentType = "",
                            DateCreated = DateTime.Now,
                            FileImage = fileToUpload,
                        };

                        if (br != null)
                        {
                            br.Close();
                        }
                        if (fs != null)
                        {
                            fs.Close();
                        }
                        CurrentlyUploadedFiles.Add(newFile);
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                    finally
                    {
                        if (br != null)
                        {
                            br.Close();
                        }
                        if (fs != null)
                        {
                            fs.Close();
                        }
                    };
                }
                if (CurrentlyUploadedFiles.Count > 0 && AutomaicallyAddFileToDatabase)
                {
                    using (var DbConnection = new MCDEntities())
                    {
                        DbConnection.Files.AddRange(CurrentlyUploadedFiles);
                        DbConnection.SaveChanges();
                    };
                }
            }
            return CurrentlyUploadedFiles;
        }
        public static Boolean RemoveFile(List<Data.Models.File> FilesToRemove)
        {
            Boolean Rtn = false;
            try
            {
                using (var Dbconnection = new MCDEntities())
                {
                    foreach (Data.Models.File f in FilesToRemove)
                    {
                        Dbconnection.Files.Attach(f);
                    }
                    Dbconnection.Files.RemoveRange(FilesToRemove);
                    Rtn = true;
                };
            }
            catch (Exception ex)
            {
                Rtn = false;
            }
            return Rtn;
        }
        public static Boolean RemoveFile(Data.Models.File FileToRemove)
        {
            Boolean Rtn = false;

            List<Data.Models.File> x = new List<Data.Models.File>();
            x.Add(FileToRemove);
            Rtn = RemoveFile(x);
            return Rtn;
        }
        public static Boolean RemoveFile(int FileID)
        {
            Boolean Rtn = false;

            using (var Dbconnection = new MCDEntities())
            {
                Data.Models.File f = (from a in Dbconnection.Files
                                      where a.FileID == FileID
                                      select a).FirstOrDefault<Data.Models.File>();
                Dbconnection.Files.Remove(f);
                Dbconnection.SaveChanges();
                Rtn = true;
            };
            return Rtn;
        }
        public static Impendulo.Data.Models.File GetFile(int FileID = 0)
        {

            Impendulo.Data.Models.File CurrentFile = null;

            using (var Dbconnection = new MCDEntities())
            {
                CurrentFile = (from a in Dbconnection.Files
                               where a.FileID == FileID
                               select a).FirstOrDefault<Impendulo.Data.Models.File>();
            };
            return CurrentFile;
        }
    }
}
