using System;
using System.Collections;
using static System.Console;

namespace InitializingCollections
{
    class MainApp
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 20, 30 }; // Array

            ArrayList list = new ArrayList(arr); // Collection
            foreach (int a in arr)
            {
                Write($"{a} ");                
            }
            WriteLine();

            ArrayList list2 = new ArrayList() { 40, 50, 60 };
            foreach (int b in list2)
            {
                Write($"{b} ");
            }
            WriteLine();

            Stack stack = new Stack(arr);
            foreach (int a in arr)
            {
                Write($"{a} ");
            }
            WriteLine();

            // Stack stack2 = new Stack() { 40, 50, 60 };
            // Queue queue = new Queue() { 10, 20, 30 };
            // (Stack과 Queue)는 IEnumerable인터페이스와 Add()메서드가 없기에 구현 X
        }
    }
}
