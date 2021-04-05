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
            vova.course = 2;
            if ( ( vova.course > 5 ) || ( vova.course < 1 ) ) Console.WriteLine( "There is no such course" );
            else Console.WriteLine( $"Course: {vova.course}" );
            vova.NameTeacher = "Sergey Eduardovich";
            vova.Subject = "Mathematical analysis";
            Console.WriteLine( $"Subject: {vova.Subject}({vova.NameTeacher})" );
            Console.Write( $"{vova.NameStudent} passed the threshold? " );
            vova.Test(200);
            Console.Write( $"Will {vova.NameStudent} have a scholarship? " );
            vova.AddingStipend();
            Console.ReadKey();
        }
    }
}
