using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTriangle
{
    public class Triangle
    {
        public double Hypotenuse(int sideA, int sideB)
        {
            double sideC;
            int temp; 
            sideA = sideA * sideA;
            sideB = sideB * sideB;
            temp = sideB + sideA;
            sideC = Math.Sqrt(temp);
            Console.Write(sideC);
            return (sideC);

        }

        public double Area(int sideA, int sideB)
        {
            double area = 0.0;
            area = 0.5 * (sideA * sideB);
            return (area);
        }

    }
}
