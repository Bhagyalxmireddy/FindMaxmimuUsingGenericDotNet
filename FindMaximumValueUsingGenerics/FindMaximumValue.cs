using System;
using System.Collections.Generic;
using System.Text;

namespace FindMaximumValueUsingGenerics
{
    public class FindMaximumValue
    {
        public class GenericMaximu<T> where T : IComparable
        {
            public T x, y, z;

            public GenericMaximu(T x, T y, T z)
            {
                this.x = x;
                this.y = y;
                this.z = z;
            }
            public static T Maximum(T x, T y, T z)
            {
                T max = x;
                if (y.CompareTo(max) > 0)
                {
                    max = y;
                }
                if (z.CompareTo(max) > 0)
                {
                    max = z;
                }
                return max;
            }
            public T maximumMethod()
            {
                T max = GenericMaximu<T>.Maximum(this.x, this.y, this.z);
                return max;
             }
           
        }
    }
}
