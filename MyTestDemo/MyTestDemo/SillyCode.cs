using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTestDemo
{
    public class SillyCode
    {
        public int Value { get; set; }

        public string GetName(string[] names, int index) 
        { 
            return names[index]; 
        }

        public int GetSum(int[] numbers, int corr=0)
        {
            return numbers.Sum()-corr;
        }

        public int GetLength(string text)
        {
            return (text?.Length) ?? 0;
        }

    }
}
