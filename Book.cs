using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook
{

    #region (Abstract Class Book)
    public abstract class Book : NamedObject, IBook
    {
        public Book(string name) : base(name)
        {
        }

        public abstract void AddGrade(double grade);

        public abstract Statistics GetStatistics();

        public abstract void ShowStatistics(Statistics grades);


        public abstract event GradeAddedDelegate GradeAdded;

        public double AskForAGrade()
        {
            {
                {
                    bool testGrade = false;
                    double grade = 0.0;
                    string? gradeString;
                    Console.WriteLine("Enter your new grade");
                    gradeString = Console.ReadLine();
                    while (!testGrade)
                    {

                        testGrade = double.TryParse(gradeString, out grade);
                        if (!testGrade || grade < 0.0 || grade > 100.0)
                        {
                            Console.WriteLine("Invalid value entered, please retry");
                            gradeString = Console.ReadLine();
                            testGrade = false;
                        }
                    }

                    return grade;
                }
            }
        }
    }
    #endregion
   
}
