using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    interface ISubject
    {
        string TeacherName { get; set; }
        string Subject { get; set; }
        void CheckTheExamThreshold( int mark );
    }
}
