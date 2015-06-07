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
            Gradebook g1 = new Gradebook();
            Gradebook g2 = g1;

            Console.WriteLine(g2.Name);
            //Gradebook book = new Gradebook();
            //book.AddGrade(91f);
            //book.AddGrade(89.1f);
            //book.AddGrade(75);

            //GradeStatistics stats = book.ComputeStatistics();

            //Console.WriteLine(stats.AverageGrade);
            //Console.WriteLine(stats.LowestGrade);
            //Console.WriteLine(stats.HighestGrade);
        }
    }

}
