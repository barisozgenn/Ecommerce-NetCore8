using System;
using Microsoft.AspNetCore.Http;
using System.Net;

namespace Business.Utilities.File
{
    public class FileManager : IFileService
    {
        public string FileSave(IFormFile file, string filePath, string fileName, string fileTag)
        {

            var extension = "." + file.FileName.Split(".").Last().ToLower();
            string uniqueFileName = fileTag + "-" + fileName + "-" + Guid.NewGuid().ToString().ToLower() + extension;

            using (var stream = System.IO.File.Create(path: filePath + uniqueFileName))
            {
                file.CopyTo(stream);
            }

            return uniqueFileName;
        }

        public string FileSaveToFtp(IFormFile file, string filePath, string fileName, string fileTag)
        {
            var extension = "." + file.FileName.Split(".").Last().ToLower();
            string uniqueFileName = fileTag + "-" + fileName + "-" + Guid.NewGuid().ToString().ToLower() + extension;

            FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create("ftp /" + filePath + uniqueFileName);
            ftpWebRequest.Credentials = new NetworkCredential("kullanıcı adı", "şifre");
            ftpWebRequest.Method = WebRequestMethods.Ftp.UploadFile;

            using (Stream ftpStream = ftpWebRequest.GetRequestStream())
            {
                file.CopyTo(ftpStream);
            }

            return uniqueFileName;
        }
    }
}

