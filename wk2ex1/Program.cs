using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace wk2ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //prompt user to insert a numeric score
            Console.WriteLine("What is a numeric score (0 to 100)?");
            int score = int.Parse(Console.ReadLine());
            //calculate the letter grade
            string grade = GetGrade(score);
            //prompt user to enter student grade
            Console.WriteLine($"The students grades is: {grade}");
        }
        //calculate the letter grade based on numeric grade
        static string GetGrade(int score)
        {
            if (score >= 90)
            {
                return "A";
            }
            else if (score >= 80)
            {
                return "B";
            }
            else if (score >= 70)
            {
                return "C";
            }
            else if (score >= 60)
            {
                return "D";
            }
            else
            {
                return "F";
            }
        }
    }
}
        
