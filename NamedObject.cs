using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook
{
    #region (NamedObject)
    public class NamedObject
    {
        #region Constructors (namedobject)
        public NamedObject(string name)
        {
            Name = name;
        }

        #endregion
        #region properties (namedobject)
        public string Name
        {
            get;
            set;
        }
        #endregion
    }
    public delegate void GradeAddedDelegate(object sender, EventArgs args);
    #endregion
}
