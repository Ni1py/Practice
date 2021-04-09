using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    public abstract class Grant : ISubject
    {
        private bool exam;
        public string TeacherName { get; set; }
        public string Subject { get; set; }
        public void Test( int mark )
        {
            if (mark == 300)
            {
                exam = true;
                Console.WriteLine( "Yes" );
            }
            else
            {
                exam = false;
                Console.WriteLine( "No" );
            }
            Console.WriteLine( $"Total score: {mark}" );
        }
        public void Pay()
        {
            if (exam)
            {
                Console.WriteLine( "Yes" );
            }
            else
            {
                Console.WriteLine( "No" );
            }
        }
    }
}
