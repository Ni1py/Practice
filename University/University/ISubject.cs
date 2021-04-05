using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    interface ISubject
    {
        string NameTeacher { get; set; }
        string Subject { get; set; }
        void Test( int mark );
    }
}
