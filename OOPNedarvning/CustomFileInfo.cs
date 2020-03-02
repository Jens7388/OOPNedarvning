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
                (bool isTooLarge, string errorMessage) validationResult = IsSizeTooLarge(value);
                if(validationResult.isTooLarge)
                {
                    throw new ArgumentException(nameof(fileSize), validationResult.errorMessage);
                }
                if(value != fileSize)
                {
                    fileSize = value;
                }
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
        public virtual (bool, string) IsSizeTooLarge(int fileSize)
        {
            if(fileSize > 45)
            {
                return (true, "Filen må ikke være på mere end 45 mb!");
            }
            else
            {
                return (false, String.Empty);
            }
        }
        public override string ToString()
        {
            return ("Filnavn: " + fileName);
        }
    }
}