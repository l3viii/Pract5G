using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_5G
{
    class Pair
    {
        public int First { get; set; }
        public int Second { get; set; }

        public Pair(int first, int second)
        {
            First = first;
            Second = second;
        }

        public Pair Multiply(Pair multiplication)
        {
           return new Pair(First * multiplication.First, Second * multiplication.Second);
        }

        public Pair Multiply()
        {
            return new Pair(First * 2, Second * 2); 
        }
    }
}
