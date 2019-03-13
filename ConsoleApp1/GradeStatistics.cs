using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class GradeStatistics
    {
        public GradeStatistics()
        {
            HighestGrade = 0;
            LowestGrade = float.MaxValue;
        }
        public float AverageGrade;
        public float LowestGrade;
        public float HighestGrade;
    }
}
