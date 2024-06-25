using System;
namespace CSharp_Practice.CSharpConceptsPractice.ExtensionMethods
{
    public static class ExtensionMethodsInt
    {
        public static bool IsGT(this int i, int value)
        {
            if (i > value)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
