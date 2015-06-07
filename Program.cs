using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShrp_Gradebook
{
    class Program
    {

        static void Main(string[] args)
        {
            Arrays();
        }

        private static void Arrays()
        {
            float[] grades;

            grades = new float[3];

            AddGrades();

            grades[0] = 91f;
            grades[1] = 89.1f;
            grades[2] = 75f;

            foreach(float grade in grades)
            {
                Console.WriteLine(grade);
            }
        }

        private static void AddGrades(float[] grades)
        {
            grades[0] = 91f;
            grades[1] = 89.1f;
            grades[2] = 75f;
        }
    }

}
