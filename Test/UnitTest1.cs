using OOPNedarvning;
using System;
using Xunit;

namespace Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            VideoFileInfo v = new VideoFileInfo("VideoFileInfo.xxx", 45, new DateTime(1969, 9, 6), 1920, 1080, 420);
            v.IsSizeTooLarge();
            DocumentFileInfo d = new DocumentFileInfo("DocumentFileInfo.xxx", 45, new DateTime(1969, 9, 6));
            d.IsSizeTooLarge();
        }
    }
}
