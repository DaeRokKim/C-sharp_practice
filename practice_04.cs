using System;

namespace Overflow
{
    class MainApp
    {
        static void Main(String[] args)
        {
            // uint a = uint.MaxValue;   
            int a = int.MaxValue;   // uint 대신  int 사용

            Console.WriteLine(a);

            a = a + 1;

            Console.WriteLine(a);
        }
    }
}



