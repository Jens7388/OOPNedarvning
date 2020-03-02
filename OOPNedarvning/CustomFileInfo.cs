using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace OOPNedarvning
{
    abstract class CustomFileInfo
    {
        protected string fileName;
        protected int fileSize;
        protected DateTime creationTime;

        public string FileName
        {
            get
            {
                return fileName;
            }

            set
            {
                fileName = value;
            }
        }

        public int FileSize
        {
            get
            {
                return fileSize;
            }

            set
            {
                fileSize = value;
            }
        }

        public DateTime CreationTime
        {
            get
            {
                return creationTime;
            }

            set
            {
                creationTime = value;
            }
        }

        protected CustomFileInfo(string fileName, int fileSize, DateTime creationTime) 
        {
            FileName = fileName;
            FileSize = fileSize;
            CreationTime = creationTime;
        }
        public (bool, string) ValidateFileSize(int fileSize)
        {
            if(fileSize > 45)
            {
                return (false, "Filen må ikke være på mere end 45 mb!");
            }
            if(fileSize == 0) 
            {
                return (false, "Filens størrelse er ugyldig!");
            }
            if
                { }
        }
    }
}
