using System;

namespace OOPNedarvning
{
    class Program
    {
        static void Main()
        {
            try
            {
                VideoFileInfo v = new VideoFileInfo("VideoFileInfo.xxx", 45, new DateTime(1969, 9, 6), 1920, 1080, 420);
                v.IsSizeTooLarge();
                DocumentFileInfo d = new DocumentFileInfo("DocumentFileInfo.xxx", 45, new DateTime(1969, 9, 6));
                d.IsSizeTooLarge();
                Console.WriteLine(v.ToString());
                Console.WriteLine(d.ToString());
                Console.ReadLine();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}