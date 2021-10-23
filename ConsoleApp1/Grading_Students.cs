using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolvings
{
    public class Grading_Students
    {
        public Grading_Students()
        {
            int n = int.Parse(Console.ReadLine());
            List<int> list = new List<int>();
            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());
                list.Add(input);
            }

            foreach (int a in list)
            {
                int output = a;
                if (a >= 38)
                {
                    int take = a / 5;
                    int multiplied = (take + 1) * 5;
                    if ((multiplied - a) < 3)
                    {
                        output = multiplied;
                    }
                }
                Console.WriteLine(output);
            }
        }
    }
}
