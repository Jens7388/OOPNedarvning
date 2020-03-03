using System;


namespace OOPNedarvningFormer
{
    class Program
    {
        private static void MainMenu() 
        {
            Console.WriteLine("Hvilken figur ønsker du at skabe?");
            Console.WriteLine("1) Circle");
            Console.WriteLine("2) Rectangle");
            Console.WriteLine("3) Square");
            string input = Console.ReadLine();
            if(input == "1" || input.ToLower() == "circle") 
            {
                CreateCircle();
            }
            else if(input == "2" || input.ToLower() == "rectangle") 
            {
                CreateRectangle();
            }
            else if(input == "3" || input.ToLower() == "square")
            {
                CreateSquare();
            }
        }
        private static void CreateCircle() 
        {

        }
        private static void CreateRectangle() 
        {

        }
        private static void CreateSquare();
        static void Main()
        {

        }
    }
}
