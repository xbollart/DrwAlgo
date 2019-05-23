using System;
using System.Text;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace ConsoleApp2
{
    class Program
    {
        // Question 1
        static String BuildString(int n)
        {
            char prev = '-';
            var s = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                if (prev == '-')
                {
                    s.Append('+');
                    prev = '+';

                }
                else
                {
                    s.Append('-');
                    prev = '-';
                }
            }

            return s.ToString();
 
        }

        // Question 2
        static String Day(string day,int n)
        {
            Dictionary<String,int> dict = new Dictionary<string, int>()
            {{"mon",0},{"tue",1},{"wed",2},{"thu",3},{"fri",4},{"sat",5},{"sun",6}};

            String[] days = new String[] { "mon","tue","wed","thu","fri","sat","sun"};

            int index = dict[day];
            int newIndex = (index + n) % 7;
            return days[newIndex];
        }



        static void Main(string[] args)
        {
            Console.WriteLine(Day("wed",7));
            Console.WriteLine(BuildString(2));
        }
    }
}