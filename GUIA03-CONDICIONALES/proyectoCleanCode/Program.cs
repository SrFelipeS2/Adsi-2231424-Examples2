using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace CleanCode
{
    class Program
    {
        public TagList getThem(TagList list1, TagList tagList)
        {
            List<int[]> list1 = new List<int[]>();
            for (int[] x:tagList) {
                if (x[0] == 4)
                {
                    List.add(x);
                }
            }
            return list1;
        }
    }
}
