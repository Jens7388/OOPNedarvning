using System;

namespace OOPNedarvning
{
    class Program
    {
        static void Main()
        {
            try
            {
                VideoFileInfo v = new VideoFileInfo("blablabla.xxx", 45, new DateTime(1969, 9, 6), 1920, 1080, 420);
                Console.WriteLine(v.ToString());
            }
            catch(Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}