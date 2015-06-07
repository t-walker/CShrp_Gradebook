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
            Gradebook book = new Gradebook("Walker");

            book.AddGrade(91f);
            book.AddGrade(89.1f);
            book.AddGrade(75f);

            GradeStatistics stats = book.ComputeStatistics();

            book.NameChanged += onNameChanged;
            book.Name = "Tyler";
            Console.WriteLine("Average", stats.AverageGrade);
            Console.WriteLine("Lowest", stats.LowestGrade);
            Console.WriteLine("Highest", stats.HighestGrade);
        }

        private static void onNameChanged(string oldvalue, string newvalue)
        {
            Console.WriteLine("Name changed from {0} to {1}", oldvalue, newvalue);
        }
    }
}
