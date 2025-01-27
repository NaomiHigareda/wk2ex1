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
            Console.WriteLine($"The letter grade for score is: {grade}");
        }
        //calculate the letter grade based on numeric grade
        static string GetGrade(double score)
        {
            //if score is 89.5 between and 100 return an a
            if (score >= 89.5 && score <=100)
            {
                return "A";
            }
            //if the score is between 79.5 and 89.5 return a B
            else if (score >= 79.5 && score <= 89.5)
            {
                return "B";
            }
            //if the score is between 69.5 and 79.5 return C
            else if (score >= 69.5 && score <= 79.5)
            {
                return "C";
            }
            //if the score is between 59.5 and 69.5 return D
            else if (score >= 59.5 && score <= 69.5)
            {
                return "D";
            }
            //if the score is below 59.5 return F
            else 
            {
                return "F";
            }
        }
    }
}
        
