﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOPNedarvning
{
    public class DocumentFileInfo: CustomFileInfo
    {
        public DocumentFileInfo(string fileName, int fileSize, DateTime creationTime)
            : base(fileName, fileSize, creationTime)
        {

        }
    }
}