using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook
{

    #region (Class InMemoryBook)
    public class InMemoryBook : Book
    {
        #region constructors InMemoryBook
        public InMemoryBook(string name) : base(name)
        {
            grades = new List<double>();
            Name = name;
        }
        #endregion

        #region Methods

        public override void AddGrade(double grade)
        {
            grades.Add(grade);
            if (GradeAdded != null)
            {
                GradeAdded(this, new EventArgs());
            }
        }

        public override event GradeAddedDelegate GradeAdded;

        public override Statistics GetStatistics()
        {
            var result = new Statistics();

            for (var index = 0; index < grades.Count; index++)
            {
                result.Add(grades[index]);
            }

            return result;
        }
        public override void ShowStatistics(Statistics grades)
        {
            Console.WriteLine($"The average grade is {grades.Average:N1}.");
            Console.WriteLine($"The highest grade is {grades.High:N1}.");
            Console.WriteLine($"The lowest grade is {grades.Low:N1}.");
            Console.WriteLine($"The grade letter {grades.Letter}.");

        }

        #endregion

        #region Fields
        private List<double> grades;

        public const string CATEGORY = "Science";
        #endregion

    }
#endregion
}
