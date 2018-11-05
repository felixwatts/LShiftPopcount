using System;
using System.Diagnostics;

namespace popcount
{
    class Program
    {
        static void Main(string[] args)
        {
            Debug.Assert(PopCounter.PopCount(0) == 0);
            Debug.Assert(PopCounter.PopCount(8) == 1);
            Debug.Assert(PopCounter.PopCount(15) == 4);
            Debug.Assert(PopCounter.PopCount(19) == 3);

            Console.WriteLine("All tests passed");
        }
    }

    class PopCounter
    {
        public static uint PopCount(uint input)
        {
            // we could use a for loop here but it would be 
            // a fairly unconventional one and IMO harder to read

            var count = 0u;
            while(input > 0)
            {
                count += input & 1;
                input = input >> 1;
            }

            return count;
        }
    }
}
