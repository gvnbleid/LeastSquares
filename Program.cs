using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// =============================================
// Author:		Maciej Krawczyk
// Creation date: 29.05.2017
// Description:	The aim of this program is 
// to calculate a straigth line such that 
// as many points given as input  will be as close
// as possible to this line.
// =============================================


namespace LeastSquares
{
    class Program
    {
        static void Main(string[] args) //usage: x0, y0, x1, y1, x2, y2,...
        {
            Console.WriteLine("Least Squares");
            Console.WriteLine("==========================");
            Console.WriteLine();
            Console.WriteLine("Please enter the list of coordinates in format: x0 y0 x1 y1 x2 y2 ...");
            PointSet mainSet = new PointSet();
            string[] coordinates = Console.ReadLine().Split();
            for (int i=0;i<coordinates.Length;i+=2)
            {
                double x = Double.Parse(coordinates[i]);
                double y = Double.Parse(coordinates[i+1]);
                mainSet.Add(new Point(x, y));
            }
            StraightLine result = mainSet.FindApproximateSolution();
            Console.Write("Given this set of points, the approximate line is in form: ");
            Console.WriteLine(result.ToString());
        }

    }
}
