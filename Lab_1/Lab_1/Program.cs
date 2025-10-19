using System;
namespace Laba_App_1
{
    class Laba_1
    {

        /// <summary>
        /// Функция Trivial_divs ищет только тривиальные делители переданного числа num и выводит делители по возрастанию/убыванию, четные/нечетные и простые делители.
        /// Функция Not_Trivial_divs ищет только нетривиальные делители переданного числа num и выводит делители по возрастанию/убыванию, четные/нечетные и простые делители.
        /// Функция Main вызывает функции Trivial_divs и Not_Trivial_divs, передавая в них число, у которого нужно искать делители.
        /// </summary>

        static void Main()      //Главная функция
        {
            while (true){
                try
                {
                    Console.WriteLine("\n\nВведи целое число: "); 
                    int num = int.Parse(Console.ReadLine());
                    Trivial_divs(num);
                    Not_Trivial_divs(num);
                }
                catch
                {
                    Console.WriteLine("Можно вводить только числа. \nПопробуй еще раз!");
                }
            }

        }
        static void Trivial_divs(int num)       //Получение тривиальных делителей
        {
            int k = 0;
            int index = 0;
            int[] res = new int[num];
            for (int i = 2; i <= num; i++)
            {
                if (num % i == 0)
                {
                    res[index] = i;
                    ++k;
                    ++index;
                }
            }

            Console.WriteLine("\n---------------------------");
            Console.WriteLine("ТРИВИАЛЬНЫЕ ДЕЛИТЕЛИ ");
            Console.WriteLine("---------------------------");
            Console.WriteLine("\nКоличество тривиальных делителей = " + k);
            Console.WriteLine("\nСписок делителей по возрастанию: ");
            for (int i = 0; i < k; i++)                                         //Вывод только тривиальных делителей по возрастанию
            {
                Console.WriteLine(res[i]);
            }
            Console.WriteLine("\nСписок делителей по убыванию: ");
            for (int i = k - 1; i >= 0; i--)                                    //Вывод только тривиальных делителей по убыванию
            {
                Console.WriteLine(res[i]);
            }
            Console.WriteLine("\nВывод только четных делителей: ");
            for (int i = 0; i < k; i++)                                         //Вывод только четных тривиальных делителей
            {
                if (res[i] % 2 == 0)
                    Console.WriteLine(res[i]);
            }
            Console.WriteLine("\nВывод только нечетных делителей: ");
            for (int i = 0; i < k; i++)                                         //Вывод только нечетных тривиальных делителей
            {
                if (res[i] % 2 != 0)
                    Console.WriteLine(res[i]);
            }
            Console.WriteLine("\nВывод только простых чисел: ");
            foreach (int i in res[0..k])                                        //Вывод только простых тривиальных делителей
            {
                bool prostoe = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        prostoe = false;
                        break;
                    }
                }
                if (prostoe == true)
                {
                    Console.WriteLine(i);
                }
            }
        }
        static void Not_Trivial_divs(int num)       //Получение тривиальных делителей
        {
            int k = 0;
            int index = 0;
            int[] res = new int[num];
            for (int i = 2; i <= (int)(Math.Sqrt(num) + 1); i++)
            {
                if (num % i == 0)
                {
                    res[index] = i;
                    ++k;
                    ++index;
                }
            }

            Console.WriteLine("\n---------------------------");
            Console.WriteLine("НЕТРИВИАЛЬНЫЕ ДЕЛИТЕЛИ ");
            Console.WriteLine("---------------------------");
            Console.WriteLine("\nКоличество нетривиальных делителей = " + k);
            Console.WriteLine("\nСписок делителей по возрастанию: ");
            for (int i = 0; i < k; i++)                                         //Вывод только нетривиальных делителей по возрастанию
            {
                Console.WriteLine(res[i]);
            }
            Console.WriteLine("\nСписок делителей по убыванию: ");
            for (int i = k - 1; i >= 0; i--)                                    //Вывод только нетривиальных делителей по убыванию
            {
                Console.WriteLine(res[i]);
            }
            Console.WriteLine("\nВывод только четных делителей: ");
            for (int i = 0; i < k; i++)                                         //Вывод только четных нетривиальных делителей
            {
                if (res[i] % 2 == 0)
                    Console.WriteLine(res[i]);
            }
            Console.WriteLine("\nВывод только нечетных делителей: ");
            for (int i = 0; i < k; i++)                                         //Вывод только нечетных нетривиальных делителей
            {
                if (res[i] % 2 != 0)
                    Console.WriteLine(res[i]);
            }
            Console.WriteLine("\nВывод только простых чисел: ");
            foreach (int i in res[0..k])                                        //Вывод только простых нетривиальных делителей
            {
                bool prostoe = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        prostoe = false;
                        break;
                    }
                }
                if (prostoe == true)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}