using System;
using System.Collections.Generic;

namespace testTask
{
    class Program
    {

        static int[] ArrGenerator(int[] arr)
        {
            Random rnd = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(1, 20);
            }

            return arr;
        }

        static Dictionary<int, int> OccurrenceOfNubers(int[]  arr)
        {
            var obj = new Dictionary<int, int>();


            foreach (var i in arr)
            {
                int res;
                if (obj.TryGetValue(i, out res))
                    obj[i] += 1;
                else
                    obj.Add(i, 1);
            }

            return obj;
        }

        static void Main(string[] args)

        {
            //user's input 
            Console.Write("Введите длину массива чисел: ");

            var len = Console.ReadLine();
            int a = 0;
            bool t = false;

            while(t == false)
                {
                    t = int.TryParse(len, out a);
                    if(t == false)
                    {
                        Console.Clear();
                        Console.Write("Ошибка, попробуйте снова: ");
                        len = Console.ReadLine();
                    } else
                    {
                        a = Math.Abs(a);
                    }
                }

            //finding occurrence of numbers in the array
            int[] arr;
            arr = new int[a];

            arr = ArrGenerator(arr);
            var obj = OccurrenceOfNubers(arr);

            //output into console
            Console.Write("Исходный массив: ");
            foreach (var i in arr)
                Console.Write(i+" ");
            Console.WriteLine();
            Console.WriteLine();
            foreach (var i in obj)
                Console.WriteLine("     число: "+i.Key + " Повторяется: " + i.Value + " раз(а)");
            Console.ReadKey();
        }
    }
}
