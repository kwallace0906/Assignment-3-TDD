using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTriangle
{
    public class Triangle
    {
        public double RightHypotenuse(int sideA, int sideB)
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

        public double RightArea(int sideA, int sideB)
        {
            double area = 0.0;
            area = 0.5 * (sideA * sideB);
            return (area);
        }

        public int MissingAngle(int angleA, int angleB)
        {
            int angle = 0;
            angle = 180 - (angleA + angleB);

            return (angle);
        }

        public int Perimeter(int sideA, int sideB, int sideC)
        {
            return (sideA + sideB + sideC);
        }

        public int CheckIsRight(int angleA, int angleB, int angleC) //returns 1 if any angle is 90, 0 if no angles are 90
        {
            if(angleA == 90)
            {
                return (1);
            }
            else if(angleB == 90)
            {
                return (1);
            }
            else if(angleC == 90)
            {
                return (1);
            }
            else
            {
                return (0);
            }
        }

        public int isValidTriangle(int angleA, int angleB, int angleC)  //returns 1 if valid triangle (adds to 180), 0 if is not valid
        {
            return (5);
        }
    }
}
