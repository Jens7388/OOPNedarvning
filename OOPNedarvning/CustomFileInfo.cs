using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace OOPNedarvning
{
    public abstract class CustomFileInfo
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
                if(value != fileSize)
                {
                    fileSize = value;
                }
                if(IsSizeTooLarge())
                {
                    
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
        public virtual bool IsSizeTooLarge()
        {          
            if(fileSize > 45)
            {
                throw new ArgumentException("Filen må ikke være på mere end 45 mb!");                
            }
            else
            {
                return false;
            }
        }
        public override string ToString()
        {
            return ("Filnavn: " + fileName);
        }
    }
}