

using System;

namespace Cest_Le_Weekend
{
    class Program
    {
        static void Main(string [] args)
        {
            if (DateTime.Now.DayOfWeek == DayOfWeek.Saturday || DateTime.Now.DayOfWeek == DayOfWeek.Sunday)
            {
                AfficheWeekend(); 
            }

            else

            if (DateTime.Now.DayOfWeek == DayOfWeek.Monday
                || DateTime.Now.DayOfWeek == DayOfWeek.Tuesday
                || DateTime.Now.DayOfWeek == DayOfWeek.Wednesday
                || DateTime.Now.DayOfWeek == DayOfWeek.Thursday
                || DateTime.Now.DayOfWeek == DayOfWeek.Friday) ;
            else if (DateTime.Now.Hour >= 9 || DateTime.Now.Hour <= 18) 
            {
                AfficheBonjour();
            }

            else

            if (DateTime.Now.DayOfWeek == DayOfWeek.Monday
            || DateTime.Now.DayOfWeek == DayOfWeek.Tuesday
            || DateTime.Now.DayOfWeek == DayOfWeek.Wednesday
            || DateTime.Now.DayOfWeek == DayOfWeek.Thursday
            || DateTime.Now.DayOfWeek == DayOfWeek.Friday) ;
            else if (DateTime.Now.Hour <= 9 || DateTime.Now.Hour >= 18) 
            {
                AfficheBonsoir();
            }
        }

        static void AfficheWeekend()
        { Console.WriteLine("Bon Weekend " + Environment.UserName); }
        static void AfficheBonsoir()
        {   Console.WriteLine("Bonsoir " + Environment.UserName); }
        static void AfficheBonjour()
        { Console.WriteLine("Bonjour " + Environment.UserName); }
    }
}
