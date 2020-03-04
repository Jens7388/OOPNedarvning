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
                Console.WriteLine("Indtast rektanglets X akse: ");
                string input = Console.ReadLine();
                int.TryParse(input, out int x);

                Console.WriteLine("Indsast rektanglets Y akse: ");
                input = Console.ReadLine();
                int.TryParse(input, out int y);

                Console.WriteLine("Indtast rektanglets længde: ");
                input = Console.ReadLine();
                double.TryParse(input, out double length);

                Console.WriteLine("Indtast rektanglets bredde: ");
                input = Console.ReadLine();
                double.TryParse(input, out double width);

                Rectangle rectangle = new Rectangle(x, y, length, width);
                Console.WriteLine(rectangle.ToString());
                Console.ReadLine();
                Console.Clear();
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
                Console.WriteLine("Indtast kvadratets X akse: ");
                string input = Console.ReadLine();
                int.TryParse(input, out int x);

                Console.WriteLine("Indsast kvadratets Y akse: ");
                input = Console.ReadLine();
                int.TryParse(input, out int y);

                Console.WriteLine("Indtast kvadratets sidelængde: ");
                input = Console.ReadLine();
                double.TryParse(input, out double length);

                Square square = new Square(x, y, length);               
                Console.WriteLine(square.ToString());
                Console.ReadLine();
                Console.Clear();
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

