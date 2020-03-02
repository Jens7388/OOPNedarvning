using System;
using System.Collections.Generic;
using System.Text;

namespace OOPNedarvning
{
    class ImageFileInfo: CustomFileInfo
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
                (bool isTooLarge, string message) validationResult = IsTooWide(value);
                if(validationResult.isTooLarge)
                {
                    throw new ArgumentException(nameof(width), validationResult.message);
                }
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
                (bool isTooLarge, string message) validationResult = IsTooHigh(value);
                if(validationResult.isTooLarge)
                {
                    throw new ArgumentException(nameof(height), validationResult.message);
                }
                if(value != height)
                {
                    height = value;
                }
            }
        }
        public virtual (bool, string) IsTooHigh(int height)
        {
            if(height > 1080)
            {
                return (true, "Billedet er for højt!");
            }
            else
            {
                return (false, String.Empty);
            }
        }
        public virtual (bool, string) IsTooWide(int width)
        {
            if(width > 1920)
            {
                return (true, "Billedet er for bredt!");
            }
            else
            {
                return (false, String.Empty);
            }
        }
    }
}