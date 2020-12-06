using System;
using System.Collections.Generic;
using System.Text;

namespace FindMaximumValueUsingGenerics
{
    public class FindMaximumValue
    {
        public class Genericmaximum<T> where T : IComparable
        {
            public T[] value;

            public Genericmaximum(T[] value)
            {
                this.value = value;
            }
            public T[] Sort(T[] values)
            {
                Array.Sort(values);
                return values;
            }
            public T MaxValue(params T[] values)
            {
                var sorted_values = Sort(values);
                return sorted_values[^1];
            }
            public T maximumMethod()
            {
                var max = MaxValue(this.value);
                return max;
            }
            public void PrintMaxValue()
            {
                var max = MaxValue(this.value);
                Console.WriteLine("MaximumValue is : " + max);
            }
        }
    }
}
