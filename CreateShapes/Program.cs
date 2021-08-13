using CreateShapes.Entities;
using CreateShapes.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace CreateShapes
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.Write("Enter file full path: ");
            //string path = Console.ReadLine();

            //try
            //{
            //    using (StreamReader sr = File.OpenText(path))
            //    {

            //        Dictionary<string, int> dictionary = new Dictionary<string, int>();

            //        while (!sr.EndOfStream)
            //        {

            //            string[] votingRecord = sr.ReadLine().Split(',');
            //            string candidate = votingRecord[0];
            //            int votes = int.Parse(votingRecord[1]);

            //            if (dictionary.ContainsKey(candidate))
            //            {
            //                dictionary[candidate] += votes;
            //            }
            //            else
            //            {
            //                dictionary[candidate] = votes;
            //            }
            //        }

            //        foreach (var item in dictionary)
            //        {
            //            Console.WriteLine(item.Key + ": " + item.Value);
            //        }
            //    }
            //}
            //catch (IOException e)
            //{
            //    Console.WriteLine("An error occurred");
            //    Console.WriteLine(e.Message);
            //}

            List<Shape> shapes = new List<Shape>();

            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Shape #{i} data: ");
                Console.Write("Rectangle or Circle (r/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());
                if (ch == 'r')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    shapes.Add(new Rectangle(color, width, height));
                }
                else
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    shapes.Add(new Circle(color, radius));
                }
            }

            Console.WriteLine();
            Console.WriteLine("SHAPE AREAS: ");
            foreach (Shape shape in shapes)
            {
                Console.WriteLine(shape.Area().ToString("F2"));
            }

        }
    }
}
