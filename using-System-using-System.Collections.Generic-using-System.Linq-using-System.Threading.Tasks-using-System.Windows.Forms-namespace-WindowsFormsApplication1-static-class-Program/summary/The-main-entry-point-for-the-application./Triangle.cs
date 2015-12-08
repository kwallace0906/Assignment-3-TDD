/*
Software Quality 1 Assignment 3
Keith Wallace 7080906
Dec 8th 2015
The following code is a class library used for the interface of a triangle
and contains methods that have to do with finding area, perimeter, angles etc.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTriangle
{
    public class Triangle
    {
        //finds the hypotenuse of a right triangle
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

        //finds the area of a right triangle
        public double RightArea(int sideA, int sideB)
        {
            double area = 0.0;
            area = 0.5 * (sideA * sideB);
            return (area);
        }

        //finds the missing angle when supplied with 2 other angles
        public int MissingAngle(int angleA, int angleB)
        {
            int angle = 0;
            angle = 180 - (angleA + angleB);

            return (angle);
        }

        //calculates the perimeter of a triangle given 3 sides
        public int Perimeter(int sideA, int sideB, int sideC)
        {
            return (sideA + sideB + sideC);
        }

        //checks to makes sure if a triangle is a right triangle or not
        //returns 1 if any angle is 90, 0 if no angles are 90
        public int CheckIsRight(int angleA, int angleB, int angleC) 
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

        //checks to see if a triangle is a real triangle based on 3 supplied angles
        //returns 1 if valid triangle (adds to 180), 0 if is not valid
        public int isValidTriangle(int angleA, int angleB, int angleC) 
        {
            if((angleA + angleB + angleC) == 180)
            {
                return (1);
            }
            else
            {
                return (0);
            }
        }
    }
}
