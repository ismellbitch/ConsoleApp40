using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp39
{
    internal class Solution
    {
        private double x;
        private double y;

        public Solution(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public double X { get; set; }
        public double Y { get; set; }

        public string GetLeftSideSolution()
        {
            if (x >= -2 && x < 0 && y >= -2 + Math.Abs(x) && y <= 2 && y >= 0) return "Попадает";
            else return "Не попадает";
        }
        public string GetRightSideSolution()
        {
            if (x <= 2 && x > 0 && y >= 2 - Math.Abs(x) && y <= 2 && y >= 0) return "Попадает";
            else return "Не попадает";
        }
        public string GetZeroSolution()
        {
            if (x == 0 && y == 2) return "Попадает";
            else return "Не попадает";
        }
    }
}
