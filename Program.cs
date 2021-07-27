using System;
using System.Collections.Generic;

namespace testTask
{
    class Program
    {
        static void Main(string[] args)
        {

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

            int[] arr;

            arr = new int[a];

            Random rnd = new Random();

            for (int i = 0; i < arr.Length ; i++)
            {
                arr[i] = rnd.Next(1,20);
            }           

            var obj = new Dictionary<int, int>();

            foreach (var i in arr)
            {
               int res;
                if (obj.TryGetValue(i, out res))
                    obj[i] += 1;
                else
                    obj.Add(i, 1);
            }

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
