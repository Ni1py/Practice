using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    class Student : Grant
    {
        public string NameStudent;
        public int YearOfEducation;
        public void PrintStudentAndSubject()
        {
            Console.WriteLine( $"Student: {NameStudent}" );
            if ( ( YearOfEducation > 5 ) || ( YearOfEducation < 1 ) ) Console.WriteLine( "There is no such course" );
            else Console.WriteLine( $"Course: {YearOfEducation}" );

            Console.WriteLine( $"Subject: {Subject}({TeacherName})" );
        }

        public void PrintExamAndStipend( int mark )
        {
            CheckTheExamThreshold( mark );
            Console.Write( $"{NameStudent} passed the threshold? " );
            if (Exam == true) Console.WriteLine("Yes");
            else Console.WriteLine( "No" );

            Console.Write( $"Will {NameStudent} have a scholarship? " );
            PayAStipend();
        }
    }
}
