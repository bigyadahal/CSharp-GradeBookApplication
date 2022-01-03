using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook:BaseGradeBook
    {
        public RankedGradeBook(string name) : base(name)
        {
            Type = Enums.GradeBookType.Ranked;
        }

        public override char GetLetterGrade(double averageGrade)
        {
            
            if(Students.Count < 5)
            {
                throw new InvalidOperationException("Requires a minimum of 5 students to work");
            }
            var inputgrade = (int)Math.Ceiling(Students.Count * 0.20);
            var studentsGrade = Students.OrderByDescending(g => g.AverageGrade).Select(g => g.AverageGrade).ToList();

            if(averageGrade >= studentsGrade[inputgrade - 1])
            {
                return 'A';
            }
            if(averageGrade >= studentsGrade[inputgrade * 2] - 1)
            {
                return 'B';
            }
            if (averageGrade >= studentsGrade[inputgrade * 3] - 1)
            {
                return 'C';
            }
            if (averageGrade >= studentsGrade[inputgrade * 4] - 1)
            {
                return 'D';
            }

        return 'F';
        }
    }
}
