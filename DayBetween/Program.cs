using System;

namespace DaysBetween
{
    public static class Program
    {
        public static void Main()
        {
            // TODO:  Get two dates from the user.
            Console.WriteLine("Enter a date: ");
            string dateOne = Console.ReadLine();
            DateTime dateBefore = DateTime.Parse(dateOne);

            Console.WriteLine("Enter another date: ");
            string dateTwo = Console.ReadLine();
            DateTime dateAfter = DateTime.Parse(dateTwo);

            

            

            Console.WriteLine(DaysBetween(dateAfter, dateBefore));

            Console.ReadLine();
        }
        public static int DaysBetween(DateTime dateAfter, DateTime dateBefore )
        {
            TimeSpan datesBetween;
            if (dateAfter > dateBefore)
            {
                datesBetween = dateAfter.Subtract(dateBefore);
            }

            else
            {
                datesBetween = dateBefore.Subtract(dateAfter);
            }
            
            int daysBetween = datesBetween.Days;
            return daysBetween;
            

        }
        // TODO: Create that has a method that counts the number of days between two different dates.
    }
}
