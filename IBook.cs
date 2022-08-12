using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook
{

    #region (Interface IBook)
    public interface IBook
    {
        double AskForAGrade();
        void AddGrade(double grade);
        void ShowStatistics(Statistics grades);
        Statistics GetStatistics();
        string Name { get; }
        event GradeAddedDelegate GradeAdded;

    }
    #endregion

}
