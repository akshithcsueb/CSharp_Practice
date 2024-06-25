/*
COLLECTIONS
 
1) ArrayList - Non-generic
2) List<T> - Generic
3) Hashset<T> - Generic

4) Dictionary<TKey, TValue> - Generic
5) SortedList<TKey, TValue> - Generic
6) SortedList - Non-generic
7) Hashable - Non-generic

8) Stack<T> - Generic
9) Queue<T> - Generic
10) Stack - Non-generic
11) Queue - Non-generic

12) BitArray - Non-generic 

 */


using System;

namespace CSharp_Practice.CSharpConceptsPractice.Collections
{
    public class GenericCollections
    {
        public static IList<int> LearnList(IList<int> values)
        {
            return values;
        }

        public static List<int> LearnListAlone(List<int> values)
        {
            return values;
        }

        public static IDictionary<int, int> LearnDictionary(IDictionary<int, int> values)
        {
            return values;
        }

        public static void Main(string[] args)
        {
            /*
            // Interface List - We can access members of Interface List (IList) alone
            IList<int> values = new List<int>();

            values.Add(2);
            values.Add(9);
            values.Add(10);
            values.Add(5);

            IList<int> output = new List<int>();
            output = LearnList(values);

            for(int i = 0; i < output.Count; i++)
            {
                Console.WriteLine(output[i]);
            }
            */

            /*
            // List - We can access members of both Interface List (IList) & List
            List<int> values1 = new List<int>();

            values1.Add(2);
            values1.Add(9);
            values1.Add(10);
            values1.Add(5);

            List<int> output1 = new List<int>();
            output1 = LearnListAlone(values1);

            for(int i = 0; i< output1.Count; i++)
            {
                Console.WriteLine(output1[i]);
            }
            */

            /*
            // List - We can pass values to the List while we create it
            //int[] arr = { 2, 4, 1, 5, 9, 3 };
            List<int> dup = new List<int>();
            dup.Add(2);
            dup.Add(9);
            dup.Add(18);
            List<int> check = new List<int>(dup);

            for(int i=0; i< check.Count; i++)
            {
                Console.WriteLine(check[i]);
            }
            */

            /*
            // Dictionary - This is used to access only members of Dictionary alone
            IDictionary<int, int> matches = new Dictionary<int, int>();
            matches.Add(1, 2);
            matches.Add(2, 3);
            matches.Add(3, 4);

            IDictionary<int, int> output = new Dictionary<int, int>();
            output = LearnDictionary(matches);

            foreach(KeyValuePair<int, int> kvp in output)
            {
                Console.WriteLine(kvp.Key + " -- " +  kvp.Value);
            }
            */
        }
    }
}
