using GradeBook.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class StandardGradeBook: BaseGradeBook
    {
       

        public StandardGradeBook(string name): base(name) //this will invoke a constructor from BaseGradeBook
        {
            Type = Enums.GradeBookType.Standard;
        }
    }
}
