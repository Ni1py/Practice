using System;

namespace University
{
    class Program
    {
        static void Main(string[] args)
        {
            Student vova = new Student();
            vova.NameStudent = "Vladimir Rudkovsky";
            Console.WriteLine( $"Student: {vova.NameStudent}" );
            vova.YearOfEducation = 2;
            if ( ( vova.YearOfEducation > 5 ) || ( vova.YearOfEducation < 1 ) ) Console.WriteLine( "There is no such course" );

            else Console.WriteLine( $"Course: {vova.YearOfEducation}" );
            vova.TeacherName = "Sergey Eduardovich";
            vova.Subject = "Mathematical analysis";
            Console.WriteLine( $"Subject: {vova.Subject}({vova.TeacherName})" );
            Console.Write( $"{vova.NameStudent} passed the threshold? " );
            vova.Test(200);
            Console.Write( $"Will {vova.NameStudent} have a scholarship? " );
            vova.Pay();
            Console.ReadKey();
        }
    }
}
