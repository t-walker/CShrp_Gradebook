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
            Gradebook book = new Gradebook();

            book.AddGrade(91f);
            book.AddGrade(89.1f);
            book.AddGrade(75f);

            GradeStatistics stats = book.ComputeStatistics();

            Console.WriteLine("Average", stats.AverageGrade);
            Console.WriteLine("Lowest", stats.LowestGrade);
            Console.WriteLine("Highest", stats.HighestGrade);
        }
    }
}
