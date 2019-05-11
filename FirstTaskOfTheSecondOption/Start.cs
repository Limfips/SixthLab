using System;

namespace FirstTaskOfTheSecondOption
{
    public static class Start
    {
        /// <summary>
        ///     Проверка работы класса Time
        /// </summary>
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Первое время:");
                var firstTime = new Time(2, 0, 12);
                Console.WriteLine(firstTime.ToString());
                
                firstTime.Second -= 11;
                firstTime.Hour += 24;

                Console.WriteLine(firstTime.ToString());
                Console.WriteLine("Второе время:");
                var secondTime = new Time(6, 10, 90);
                Console.WriteLine(secondTime.ToString());
                Console.WriteLine("Третье время:");
                var thirdTime = new Time(12, 12, 12);
                Console.WriteLine(thirdTime.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}