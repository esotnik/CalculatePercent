using System;

namespace CalculatePercent
{
    class Program
    {
        // Пример ввода 100.00 12 1

        //В конце каждого месяца происходит капитализация — к сумме прибавляется накопившийся за месяц процент.Далее процент вычисляется от этой увеличенной суммы.
        //Процентная ставка — годовая(то есть в конце месяца сумма на счете увеличивается на одну двенадцатую ставки)
        //Считайте, что вклад открыт в первый день месяца, а срок вклада — это целое количество месяцев.
        //Код, решающий основную задачу нужно оформить в виде метода Calculate, принимающего строку, введенную пользователем. В этой задаче гарантируется, что ввод корректный.
        //Решите эту задачу без использования циклов!
        //https://ulearn.me/course/basicprogramming/Praktika_Protsenty__6cc09002-9973-4328-a31b-c7343f8c6b5d?autoplay=true
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            double sum = Calculate(s);
            Console.WriteLine(sum);
        }

        public static double Calculate(string str)
        {
            var parts = str.Split();
            double originalSum = double.Parse(parts[0]);
            double percentRate = double.Parse(parts[1]); ;
            int period = int.Parse(parts[2]); ;
            originalSum = originalSum * Math.Pow((1 + percentRate / (12 * 100)), period);
            return originalSum;
        }
    }
}
