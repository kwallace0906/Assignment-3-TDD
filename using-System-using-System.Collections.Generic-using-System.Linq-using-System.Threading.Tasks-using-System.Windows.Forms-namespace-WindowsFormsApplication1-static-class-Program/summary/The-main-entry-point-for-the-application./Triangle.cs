using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    class Triangle
    {
        int sideA = 0;
        int sideB = 0;
        double sideC = 0;

        int angleA = 0;
        int angleB = 0;
        int angleC = 0;

        public double Hypotenuse(int sideA, int sideB)
        {
            sideC = (sideA ^ 2) + (sideB ^ 2);
            sideC = Math.Sqrt(sideC);
            return (sideC);
        }


    }


}
