using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook
{

    #region (Class DiskBook)
    public class DiskBook : Book
    {
        public DiskBook(string name) : base(name)
        {
        }
        public override event GradeAddedDelegate GradeAdded;

        public override void AddGrade(double grade)
        {
            using (var writer = File.AppendText($"{Name}.txt"))
            {
                writer.WriteLine(grade);
                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }

        }

        public override Statistics GetStatistics()
        {
            var result = new Statistics();

            using (var reader = File.OpenText($"{Name}.txt"))
            {
                var line = reader.ReadLine();
                while (line != null)
                {
                    var number = double.Parse(line);
                    result.Add(number);
                    line = reader.ReadLine();
                }
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
    }
    #endregion

}
