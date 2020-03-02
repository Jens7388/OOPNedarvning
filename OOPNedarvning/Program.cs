using System;

namespace OOPNedarvning
{
    class Program
    {
        static void Main()
        {
            try
            {
                ImageFileInfo imageFile = new ImageFileInfo("blablabla.xxx", 45, new DateTime(1969, 9, 6), 1920, 1080);
            }
            catch(Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
