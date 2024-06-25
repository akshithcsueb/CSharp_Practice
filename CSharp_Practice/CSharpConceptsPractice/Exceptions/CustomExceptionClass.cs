using System;

namespace CSharp_Practice.CSharpConceptsPractice.Exceptions
{
    class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
    }

    public class CustomExceptionClass : Exception
    {
        public CustomExceptionClass() { }

        public CustomExceptionClass(string name) : base(string.Format("Invalid student name - {0}", name)) { }
    }
}
