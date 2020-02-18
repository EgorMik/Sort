using System;

namespace Sort
{
    public class Program
    {
  
       
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число элементов массива");
            int a = Convert.ToInt32(Console.ReadLine());

            int[] numbers = new int[a];
            Random rnd = new Random();

            for (int i = 0; i < a; i++)
            {

                int y = rnd.Next(3, 60);

                numbers[i] = y;

            }
            Console.Write("Введённый масив:");
            foreach (var r in numbers)
            {
                Console.Write(r+" ");
            }
            Console.WriteLine("");



            ///////////////////////////////////////////////

            for (int i = 0; i <a; i++)
            {
                for (int j = 0; j < a-1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
                }
            }
            Console.Write($"Отсортированный массив методом 'Пузырька': ");
            for (int i = 0; i < a; i++)
            {

                Console.Write(numbers[i] + " ");
            }
            
            Console.ReadKey();
        }

    }        
}
