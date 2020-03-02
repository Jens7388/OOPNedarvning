using System;
using System.Collections.Generic;
using System.Text;

namespace OOPNedarvning
{
    class VideoFileInfo: ImageFileInfo
    {
        private int duration;
        public VideoFileInfo(string fileName, int fileSize, DateTime creationTime, int width, int height, int duration)
            : base(fileName, fileSize, creationTime, width, height)
        {
            Duration = duration;
        }

        public int Duration
        {
            get
            {
                return duration;
            }

            set
            {
                duration = value;
            }
        }
        public override string ToString()
        {
            return "Video: " + fileName;
        }
    }
}