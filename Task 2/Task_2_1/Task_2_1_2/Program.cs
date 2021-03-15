using System;
using System.Collections.Generic;

namespace Task_2_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name ");
            string userName = Console.ReadLine();
            User MainUser = new User(userName);
            int choice = 0;
            int typeOfShape = 0;
            while (choice != 5) {
                Console.WriteLine($"{MainUser.Name}, please, select an action: \n 1. Add a shape\n 2. Display figures\n 3. Clear screen\n 4. Change user\n 5. Exit");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine($"{MainUser.Name}, please, select a figure: \n 1. Circle\n 2. Ring\n 3. Square\n 4. Rectangle\n 5. Triangle");
                        typeOfShape = int.Parse(Console.ReadLine());
                        break;
                    case 2:
                        int count = 0;
                        if (MainUser.OutCircle.Count != 0)
                            foreach (Circle figure in MainUser.OutCircle)
                                figure.Output();
                        else
                            ++count;
                        if (MainUser.OutRing.Count != 0)
                            foreach (Ring figure in MainUser.OutRing)
                                figure.Output();
                        else
                            ++count;
                        if (MainUser.OutSquare.Count != 0)
                            foreach (Square figure in MainUser.OutSquare)
                                figure.Output();
                        else
                            ++count;
                        if (MainUser.OutRectangle.Count != 0)
                            foreach (Rectangle figure in MainUser.OutRectangle)
                                figure.Output();
                        else
                            ++count;
                        if (MainUser.OutTriangle.Count != 0)
                            foreach (Triangle figure in MainUser.OutTriangle)
                                figure.Output();
                        else
                            ++count;
                        if (count == 5)
                            Console.WriteLine("No figures!");
                        break;
                    case 3:
                        MainUser.OutCircle.Clear();
                        MainUser.OutRing.Clear();
                        MainUser.OutSquare.Clear();
                        MainUser.OutRectangle.Clear();
                        MainUser.OutTriangle.Clear();
                        Console.WriteLine("Figures removed!");
                        break;
                    case 4:
                        Console.WriteLine("Enter your name ");
                        userName = Console.ReadLine();
                        MainUser.Name = userName;
                        break;
                }
                int typeOfInput = 0;
                if (choice == 1)
                {
                    switch (typeOfShape)
                    {
                        case 1:
                            Console.WriteLine("Select the shape input type: \n 1. Center point and radius\n 2. Only radius (center point (0;0))");
                            typeOfInput = int.Parse(Console.ReadLine());
                            Circle circle = new Circle();
                            double r_circle = 0;
                            double x_circle = 0;
                            double y_circle = 0;
                            if (typeOfInput == 1)
                            {
                                Console.WriteLine("Enter center point (x, y)");
                                x_circle = double.Parse(Console.ReadLine());
                                y_circle = double.Parse(Console.ReadLine());
                                Console.WriteLine("Enter radius");
                                r_circle = double.Parse(Console.ReadLine());
                                circle = new Circle(x_circle, y_circle, r_circle);
                                MainUser.AddCircle = circle;
                                Console.WriteLine("Figure Circle added!");
                            }
                            else if (typeOfInput == 2)
                            {
                                Console.WriteLine("Enter radius");
                                r_circle = double.Parse(Console.ReadLine());
                                circle = new Circle(r_circle);
                                MainUser.AddCircle = circle;
                                Console.WriteLine("Figure Circle added!");
                            }
                            else
                                Console.WriteLine("Figure Circle didn't add!");
                            break;
                        case 2:
                            Console.WriteLine("Select the shape input type: \n 1. Center point and radiuses (big and small)\n 2. Only radiuses (center point (0;0))");
                            Ring ring = new Ring();
                            typeOfInput = int.Parse(Console.ReadLine());
                            double r_ring = 0;
                            r_circle = 0;
                            x_circle = 0;
                            y_circle = 0;
                            if (typeOfInput == 1)
                            {
                                Console.WriteLine("Enter center point (x, y)");
                                x_circle = double.Parse(Console.ReadLine());
                                y_circle = double.Parse(Console.ReadLine());
                                Console.WriteLine("Enter big radius");
                                r_circle = double.Parse(Console.ReadLine());
                                Console.WriteLine("Enter small radius");
                                r_ring = double.Parse(Console.ReadLine());
                                ring = new Ring(x_circle, y_circle, r_circle, r_ring);
                                MainUser.AddRing = ring;
                                Console.WriteLine("Figure Ring added!");
                            }
                            else if (typeOfInput == 2)
                            {
                                Console.WriteLine("Enter big radius");
                                r_circle = double.Parse(Console.ReadLine());
                                Console.WriteLine("Enter small radius");
                                r_ring = double.Parse(Console.ReadLine());
                                ring = new Ring(r_circle, r_ring);
                                MainUser.AddRing = ring;
                                Console.WriteLine("Figure Ring added!");
                            }
                            else
                                Console.WriteLine("Figure Ring didn't add!");
                            break;
                        case 3:
                            Console.WriteLine("Select the shape input type: \n 1. Left lower point and left upper Y \n 2. Left lower point and side \n 3. Only side (left lower point (0;0)) ");
                            Square square = new Square();
                            typeOfInput = int.Parse(Console.ReadLine());
                            double x0 = 0;
                            double y0 = 0;
                            double y = 0;
                            double a = 0;
                            if (typeOfInput == 1)
                            {
                                Console.WriteLine("Enter left lower point (x, y) and left upper Y");
                                x0 = double.Parse(Console.ReadLine());
                                y0 = double.Parse(Console.ReadLine());
                                square = new Square(x0, y0, x0, y);
                                MainUser.AddSquare = square;
                                Console.WriteLine("Figure Square added!");
                            }
                            else if (typeOfInput == 2)
                            {
                                Console.WriteLine("Enter left lower point (x, y) and side");
                                x0 = double.Parse(Console.ReadLine());
                                y0 = double.Parse(Console.ReadLine());
                                a = double.Parse(Console.ReadLine());
                                square = new Square(x0, y0, a);
                                MainUser.AddSquare = square;
                                Console.WriteLine("Figure Square added!");
                            }
                            else if (typeOfInput == 3)
                            {
                                Console.WriteLine("Enter side");
                                a = double.Parse(Console.ReadLine());
                                square = new Square(a);
                                MainUser.AddSquare = square;
                                Console.WriteLine("Figure Square added!");
                            }
                            else
                                Console.WriteLine("Figure Square didn't add!");
                            break;
                        case 4:
                            Console.WriteLine("Select the shape input type: \n 1. Left lower point, left upper Y and right X \n 2. Left lower point and sides \n 3. Only sides (left lower point (0;0))");
                            Rectangle rectangle = new Rectangle();
                            typeOfInput = int.Parse(Console.ReadLine());
                            x0 = 0;
                            y0 = 0;
                            y = 0;
                            a = 0;
                            double x = 0;
                            double b = 0;
                            if (typeOfInput == 1)
                            {
                                Console.WriteLine("Enter left lower point (x, y), left upper Y and right X");
                                x0 = double.Parse(Console.ReadLine());
                                y0 = double.Parse(Console.ReadLine());
                                y = double.Parse(Console.ReadLine());
                                x = double.Parse(Console.ReadLine());
                                rectangle = new Rectangle(x0, y0, x0, y, x);
                                MainUser.AddRectangle = rectangle;
                                Console.WriteLine("Figure Rectangle added!");
                            }
                            else if (typeOfInput == 2)
                            {
                                Console.WriteLine("Enter left lower point (x, y) and sides a, b");
                                x0 = double.Parse(Console.ReadLine());
                                y0 = double.Parse(Console.ReadLine());
                                a = double.Parse(Console.ReadLine());
                                b = double.Parse(Console.ReadLine());
                                rectangle = new Rectangle(x0, y0, a, b);
                                MainUser.AddRectangle = rectangle;
                                Console.WriteLine("Figure Rectangle added!");
                            }
                            else if (typeOfInput == 3)
                            {
                                Console.WriteLine("Enter sides a, b");
                                a = double.Parse(Console.ReadLine());
                                b = double.Parse(Console.ReadLine());
                                rectangle = new Rectangle(a, b);
                                MainUser.AddRectangle = rectangle;
                                Console.WriteLine("Figure Rectangle added!");
                            }
                            else
                                Console.WriteLine("Figure Rectangle didn't add!");
                            break;
                        case 5:
                            Console.WriteLine("Select the shape input type: \n 1. 3 sides \n 2. 3 points ");
                            Triangle triangle = new Triangle();
                            typeOfInput = int.Parse(Console.ReadLine());
                            double x1 = 0;
                            double y1 = 0;
                            double x2 = 0;
                            double y2 = 0;
                            double x3 = 0;
                            double y3 = 0;
                            double a_side = 0;
                            double b_side = 0;
                            double c_side = 0;
                            if (typeOfInput == 1)
                            {
                                while (a_side + b_side <= c_side || a_side + c_side <= b_side || c_side + b_side <= a_side)
                                {
                                    Console.WriteLine("Enter sides a, b, c");
                                    a_side = double.Parse(Console.ReadLine());
                                    b_side = double.Parse(Console.ReadLine());
                                    c_side = double.Parse(Console.ReadLine());
                                }
                                triangle = new Triangle(a_side, b_side, c_side);
                                MainUser.AddTriangle = triangle;
                                Console.WriteLine("Figure Triangle added!");
                            }
                            else if (typeOfInput == 2)
                            {
                                while (a_side + b_side <= c_side || a_side + c_side <= b_side || c_side + b_side <= a_side)
                                {
                                    Console.WriteLine("Enter 3 points (x, y)");
                                    x1 = double.Parse(Console.ReadLine());
                                    y1 = double.Parse(Console.ReadLine());
                                    x3 = double.Parse(Console.ReadLine());
                                    y2 = double.Parse(Console.ReadLine());
                                    x3 = double.Parse(Console.ReadLine());
                                    y3 = double.Parse(Console.ReadLine());
                                    a_side = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
                                    b_side = Math.Sqrt((x2 - x3) * (x2 - x3) + (y2 - y3) * (y2 - y3));
                                    c_side = Math.Sqrt((x1 - x3) * (x1 - x3) + (y1 - y3) * (y1 - y3));
                                }
                                triangle = new Triangle(a_side, b_side, c_side);
                                MainUser.AddTriangle = triangle;
                                Console.WriteLine("Figure Triangle added!");
                            }
                            else
                                Console.WriteLine("Figure Triangle didn't add!");
                            break;
                        default:
                            Console.WriteLine("Figures didn't add!");
                            break;
                    }
                }
                typeOfInput = 0;
                typeOfShape = 0;
            }
            Console.WriteLine($"{MainUser.Name}, Good Bye!");
        }
    }
}
