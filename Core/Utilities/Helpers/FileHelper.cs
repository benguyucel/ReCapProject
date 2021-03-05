using Core.Utilities.Results;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;



namespace Core.Utilities.Helpers
{
    public class FileHelper
    {
      private static string _newFileName;

        private static string _filePath;
        private static  string CreateNewFolderPath()
        {
            string[] path = AppContext.BaseDirectory.ToString().Split('\\');
            string newPath = null;
            for (int i = 0; i < path.Length; i++)
            {
                if (i > 5) { break; }
                newPath += path[i] + "\\";
            }
            return newPath;
        }
        private static string FolderPath()
        {
            string[] path = { CreateNewFolderPath(), "Core", "AssetsFolder", "Images\\" };
            string fullPath = Path.Combine(path);
            return fullPath;
        }
        //private static string BackUpPath()
        //{
        //    string[] path = { CreateNewFolderPath(), "Core", "AssetsFolder", "Backup\\" };
        //    string fullPath = Path.Combine(path);
        //    return fullPath;

        //}
        //return new file name;
        private static string CreateNewName(IFormFile fileName)
        {
            if (Path.HasExtension(fileName.FileName))
            {
                FileInfo fileInfo = new FileInfo(fileName.FileName);
                string _fileName = Path.GetFileNameWithoutExtension(fileName.FileName).ToString();
                _newFileName = Guid.NewGuid() + fileInfo.Extension;
                return _newFileName;
            }
            else
            {
                return null;
            }
            
        }
        public static string UploadFile(IFormFile fileName)
        {
            try
            {
               
                    var _tempPath = Path.GetTempFileName();
                    using (var fileStream = new FileStream(_tempPath, FileMode.Create))
                    {
                        fileName.CopyTo(fileStream);
                    }
                    File.Move(_tempPath, FolderPath() + CreateNewName(fileName));
                    return _newFileName;
                
               
            }
            catch (Exception exception)
            {

                return exception.Message;
            }
        }
       
        public static string UpdateFile(IFormFile fileName,string ImagePath)
        {

            File.Delete(FolderPath() + ImagePath);
            return UploadFile(fileName);
        }
        public static string DeleteFile(string ImagePath)
        {
            File.Delete(FolderPath() + ImagePath);
            return null;
        }
    }
}
