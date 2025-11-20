using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    internal class ParameterDemo
    {
        public int Increase(ref int number)
        {
            number += 10;
            return number;
        }

        public void GetFullName(out string fullName)
        {
            fullName = "Abhishek Sharma";
        }

        public int SumAll(params int[] numbers)
        {
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            return sum;
        }


    }
}