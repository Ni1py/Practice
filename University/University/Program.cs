using System;

namespace University
{
    class Program
    {
        static void Main(string[] args)
        {
            Student vova = new Student();
            vova.NameStudent = "Vladimir Rudkovsky";
            vova.YearOfEducation = 2;
            vova.TeacherName = "Sergey Eduardovich";
            vova.Subject = "Mathematical analysis";

            vova.PrintStudentAndSubject();

            vova.PrintExamAndStipend(200);

            Console.ReadKey();
        }
    }
}
