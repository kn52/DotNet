using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developer
{
    public class TwoArray
    {
        public static void Two()
        {
            int[] A1 = { 1, 2, 3, 4 };
            int[] A2 = { 1, 2, 5, 6, 7, 3, 4 };

            foreach (int a in A2)
            {
                if (A1.Contains(a) == false)
                    Console.Write(a + " ");
            }
        }
    }
}
