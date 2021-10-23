using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolvings
{
    public class Number_Line_Jumps
    {
        public Number_Line_Jumps()
        {
            var result = kangaroo(0,3,4,2); //kangaroo(0, 2, 5, 3); //kangaroo(21, 6, 47, 3);
            Console.WriteLine(result);
        }
        public string kangaroo(int x1, int v1, int x2, int v2)
        {
            double valD = x1 - x2;
            double valM = v2 - v1;
            double aa = valD * valM;
            if ((valM * valD)<0 && (valD < 0 || valM < 0)) { return "NO"; }
            if (valD % valM == 0)
            { return "YES"; }
            return "NO";
        }
    }
}
