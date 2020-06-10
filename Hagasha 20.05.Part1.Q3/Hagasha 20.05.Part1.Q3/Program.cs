using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hagasha_20._05.Part1.Q3
{
    class Program
    {

        //If we ignore that there is "Int" in the Main function instead of "int"
        // and because of that the program won't work, as to the first value in the array:
        // the value of the first slot in the array a won't change. And that is because we
        // create new array in Update function. Therefore, we give value of 1 to the first
        // slot in the new array we create and not in the original one.

        static void Update(int[] a)
        {
            a = new int[3];
            a[0] = 1;
        }
        static void Main(string[] args)
        {
            Int[] a = { 5, 4, -5 };
            Update(a);
        }
    }
}
