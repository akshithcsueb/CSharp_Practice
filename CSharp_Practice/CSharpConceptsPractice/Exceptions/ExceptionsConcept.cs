using System;

namespace CSharp_Practice.CSharpConceptsPractice.Exceptions
{
    public class ExceptionsConcept
    {
        public static void PracticeWithoutException()
        {
            int value = 10;
            int output = value / 0;
            Console.WriteLine(output);
            Console.WriteLine("After Exception Occured");
        }
        public static void PracticeBasicException()
        {
            try
            {
                int value = 10;
                int output = value / 0;
                Console.WriteLine(output);
            }
            catch
            {
                Console.WriteLine("Exception Occured");
            }
            finally
            {
                Console.WriteLine("I am now in Finally block");
            }

            Console.WriteLine("After try catch finally blocks");
        }

        public static void PracticeExceptionWithGeneralCatchParameter()
        {
            try
            {
                int value = 10;
                int output = value / 0;
                Console.WriteLine(output);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Occured - " + ex.Message);
            }
            finally
            {
                Console.WriteLine("I am now in Finally block");
            }

            Console.WriteLine("After try catch finally blocks");
        }

        public static void PracticeExceptionWithCatchParameterFilters()
        {
            try
            {
                int value = 10;
                int output = value / 0;
                Console.WriteLine(output);
            }
            catch (Exception ex)
            {
                if (ex is DivideByZeroException)
                {
                    Console.WriteLine("Don't divide a value by zero");
                }
                else if (ex is NullReferenceException)
                {
                    Console.WriteLine("Don't access null value");
                }
            }
            finally
            {
                Console.WriteLine("I am now in Finally block");
            }

            Console.WriteLine("After try catch finally blocks");
        }

        public static void PracticeExceptionWithThrow()
        {
            string value = null;

            try
            {
                if (value == null)
                {
                    throw new NullReferenceException("You are trying to access null value");
                }
            }
            catch (Exception ex)
            {
                if (ex is NullReferenceException)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            finally
            {
                Console.WriteLine("I am now in Finally block");
            }

            Console.WriteLine("After try catch finally blocks");
        }

        /* SAME BLOCK OF CODE STARTS HERE*/

        public static void PracticeExceptionWithThrowAlone()
        {
            try
            {
                Method1();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }

        public static void Method1()
        {
            try
            {
                Method2();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static void Method2()
        {
            string str = null;

            try
            {
                Console.WriteLine(str[0]);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        /* SAME BLOCK OF CODE ENDS HERE*/



        /* SAME BLOCK OF CODE STARTS HERE*/

        public static void PracticeExceptionCustomExceptionClass()
        {
            Student student = new Student();

            try
            {
                student = new Student();
                student.StudentID = 1;
                student.StudentName = "Varun_Krishna";

                bool validationOutput = Validate(student.StudentName);

                if (!validationOutput)
                {
                    throw new CustomExceptionClass(student.StudentName);
                }

                Console.WriteLine("Student name is valid");
            }
            catch (CustomExceptionClass ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static bool Validate(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '_')
                {
                    return false;
                }
            }

            return true;
        }

        /* SAME BLOCK OF CODE ENDS HERE*/

        public static void Main(string[] args)
        {
            //PracticeWithoutException();
            //PracticeBasicException();
            //PracticeExceptionWithGeneralCatchParameter();
            //PracticeExceptionWithCatchParameterFilters();
            //PracticeExceptionWithThrow();
            //PracticeExceptionWithThrowAlone();
            PracticeExceptionCustomExceptionClass();
        }
    }
}
