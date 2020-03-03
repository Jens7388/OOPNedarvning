using ShapeEntities;
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
            try
            {
                Console.Clear();
                Console.WriteLine("Indtast cirklens X akse: ");
                string input = Console.ReadLine();
                int.TryParse(input, out int x);

                Console.WriteLine("Indsast cirklens Y akse: ");
                input = Console.ReadLine();
                int.TryParse(input, out int y);

                Console.WriteLine("Indtast cirklens radius: ");
                input = Console.ReadLine();
                double.TryParse(input, out double radius);

                Circle circle = new Circle(x, y, radius);
                Console.WriteLine(" ");
                Console.WriteLine(circle.ToString());
                Console.ReadLine();
                Console.Clear();
                MainMenu();
            }
            catch(Exception ex)
            {

                Console.WriteLine(ex.Message);
                Console.ReadLine();
                Console.Clear();
                CreateCircle();
            }
        }

        private static void CreateRectangle()
        {
            try
            {
                Console.Clear();
                //WIP
                MainMenu();
            }
            catch(Exception ex)
            {

                Console.WriteLine(ex.Message);
                Console.ReadLine();
                Console.Clear();
                CreateRectangle();
            }
        }

        private static void CreateSquare()
        {
            try
            {
                Console.Clear();
                //WIP
                MainMenu();
            }
            catch(Exception ex)
            {

                Console.WriteLine(ex.Message);
                Console.ReadLine();
                Console.Clear();
                CreateSquare();
            }
        }

        static void Main()
        {
            MainMenu();
        }
    }
}

