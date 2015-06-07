using System;
using System.Collections.Generic;


namespace CShrp_Gradebook
{
    class Gradebook
    {
        public Gradebook()
        {
            grades = new List<float>();
        }

        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade < 100)
            {
                grades.Add(grade);
            }
        }

        public GradeStatistics ComputeStatistics()
        {
            GradeStatistics stats = new GradeStatistics();
            float sum = 0f;

            foreach(float grade in grades)
            {
                sum += grade;
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
            }
            
            stats.AverageGrade = sum / grades.Count;

            return stats;
        }

        public string Name; 

        private List<float> grades;
    }
}
