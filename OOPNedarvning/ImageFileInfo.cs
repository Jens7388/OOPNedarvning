using System;
using System.Collections.Generic;
using System.Text;

namespace OOPNedarvning
{
     public class ImageFileInfo: CustomFileInfo
    {
        protected int width;
        protected int height;

        public ImageFileInfo(string fileName, int fileSize, DateTime creationTime, int width, int height)
           : base(fileName, fileSize, creationTime)
        {
            Width = width;
            Height = height;
        }

        public int Width
        {
            get
            {
                return width;
            }
            set
            {             
                if(value != width)
                {
                    width = value;
                }
            }
        }

        public int Height
        {
            get
            {
                return height;
            }
            set
            {              

                if(value != height)
                {
                    height = value;
                }
            }
        }
        public override bool IsSizeTooLarge()
        {
            if(fileSize > 45)
            {
                throw new ArgumentException("Filen må ikke være på mere end 45 mb!");
            }
            if(width > 1920)
            {
                throw new ArgumentException("Billedet er for bredt!");
            }
            if(height > 1080)
            {
                throw new ArgumentException("Billedet er for højt!");
            }
            else
            {
                return false;
            }
        }
    }
}