using System;

namespace CSharp_Practice.CSharpConceptsPractice.Generics
{
    public class BasicMathOperations<TFirstValue, TSecondValue>
    {
        public TFirstValue FirstValue;
        public TSecondValue SecondValue;

        public BasicMathOperations(TFirstValue firstValue, TSecondValue secondValue)
        {
            this.FirstValue = firstValue;
            this.SecondValue = secondValue;
        }

        public TFirstValue Add()
        {
            return (dynamic)FirstValue + (dynamic)SecondValue;
        }
    }
}
