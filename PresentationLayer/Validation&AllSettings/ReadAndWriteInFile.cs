using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileImad = System.IO;
using System.IO;

namespace Pharmacy_Management_System.Validation_AllSettings
{
    public static class ReadAndWriteInFile
    {
        public static void AddPictureInFolder(string SourcePicture)
        {
            string Path = @"D:\(PMS)\Pharmacy Management System\PictureOfUsers";

            if (!Directory.Exists(Path))
            {
                Directory.CreateDirectory(Path);
            }

            string FileName = FileImad.Path.GetFileName(SourcePicture);
            string STRDestination = FileImad.Path.Combine(Path, FileName);

            File.Copy(SourcePicture, STRDestination,true);
        } 

    }
}
