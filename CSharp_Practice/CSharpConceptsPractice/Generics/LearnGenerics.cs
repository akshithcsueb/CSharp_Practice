using System;

namespace CSharp_Practice.CSharpConceptsPractice.Generics
{
    public class LearnGenerics
    {
        public static void Main(String[] args)
        {
            BasicMathOperations<float, float> learn = new BasicMathOperations<float, float>(3.2f, 4.9f);
            Console.WriteLine(learn.Add());
        }
    }
}
