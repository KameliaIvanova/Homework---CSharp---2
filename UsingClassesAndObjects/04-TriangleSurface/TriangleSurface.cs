/*
 * Problem 4. Triangle surface
 * 
 * Write methods that calculate the surface of a triangle by given:
 * Side and an altitude to it;
 * Three sides;
 * Two sides and an angle between them;
 * Use System.Math.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_TriangleSurface
{
    class TriangleSurface
    {
        static void Main()
        {
            decimal a = 4m;
            decimal b = 13m;
            decimal c = 15m;
            decimal altitude = 12m;
            decimal angle = 67.4m;
            angle = angle * (decimal)Math.PI / 180.0m;

            SurfaceByGivenSideAndAltitude(a, altitude);
            SurfaceByGivenThreeSides(a, b, c);
            SurfaceByGivenTwoSidesAndAngle(a, b, angle);
        }

        static void SurfaceByGivenSideAndAltitude(decimal side, decimal altitude)
        {
            decimal surface = 0;

            surface = (side * altitude) / 2;

            Console.WriteLine("The surface of a truangle is: {0:F2} - side and an altitude.", surface);
        }

        static void SurfaceByGivenThreeSides(decimal side1, decimal side2, decimal side3)
        {
            decimal perimeter = (side1 + side2 + side3) / 2;
            decimal surface = 0;

            surface = (decimal)Math.Sqrt((double)(perimeter * (perimeter - side1) * (perimeter - side2) * (perimeter - side3)));

            Console.WriteLine("The surface of a truangle is: {0:F2} - three sides.", surface);
        }

        static void SurfaceByGivenTwoSidesAndAngle(decimal side1, decimal side2, decimal angle)
        {
            decimal surface = 0;

            surface = (side1 * side2 * (decimal)Math.Sin((double)angle)) / 2;

            Console.WriteLine("The surface of a truangle is: {0:F2} - two sides and an angle.", surface);
        }
    }
}
