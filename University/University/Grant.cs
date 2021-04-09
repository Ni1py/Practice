using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    public abstract class Grant : ISubject
    {
        public bool Exam;
        public string TeacherName { get; set; }
        public string Subject { get; set; }

        public void CheckTheExamThreshold( int mark )
        {
            Console.WriteLine( $"Total score: {mark}" );

            if ( mark == 300 ) Exam = true;
            else Exam = false;
        }

        public void PayAStipend()
        {
            if ( Exam ) Console.WriteLine( "Yes" );
            else Console.WriteLine( "No" );
        }
    }
}
