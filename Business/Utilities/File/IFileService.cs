using System;
using Microsoft.AspNetCore.Http;

namespace Business.Utilities.File
{
    public interface IFileService
    {
        string FileSave(IFormFile file, string filePath, string fileName, string fileTag);
        string FileSaveToFtp(IFormFile file, string filePath, string fileName, string fileTag);
    }
}

