using System;

namespace ArchitectArithmetic
{
    class Program
    {

        static double areaOfCirc(double radius)
        {
            return Math.PI * (Math.Pow(radius, 2));
        }

        static double areaOfRec(double length, double width)
        {
            return length * width;
        }

        static double areaOfTri(double bottom, double height)
        {
            return 0.5 * bottom * height;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("What is the length?");
            double length = Int32.Parse(Console.ReadLine());
            Console.WriteLine("What is the width?");
            double width = Int32.Parse(Console.ReadLine());
            Console.WriteLine("What is the height of triangle?");
            double height = Int32.Parse(Console.ReadLine());
            Console.WriteLine("What is the base of triangle?");
            double bottom = Int32.Parse(Console.ReadLine());
            Console.WriteLine("What is the radius of circle?");
            double radius = Int32.Parse(Console.ReadLine());
            double RecArea = areaOfRec(height, width);
            double halfCircArea = (areaOfCirc(radius)) / 2;
            double TriArea = areaOfTri(bottom, height);

            double totalArea = RecArea + halfCircArea + TriArea;
            double ftotalArea = Math.Round(totalArea, MidpointRounding.ToEven);

            Console.WriteLine($"The total area = {ftotalArea}");

            double totalCostOfMat = totalArea * 180;
            double ftotalCostOfMat = Math.Round(totalCostOfMat, 2);
            Console.WriteLine($"The total cost for material is {ftotalCostOfMat} pesos");
        }
    }
}
