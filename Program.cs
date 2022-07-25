using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubixHelper
{
    public static class Program
    {
        public static CubeState CurrentCubeState = CubeState.Solved;
        public static void Main()
        {
            Console.WriteLine((long)Math.Pow(Math.Pow(6, 4), 6));
            Console.WriteLine("Press any key to close...");
            Console.ReadKey();
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }
    }
}
