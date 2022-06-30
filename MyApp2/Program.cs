using System;
using System.Globalization;

namespace Myapp2
{

    class Program
    {

        static void Main(string[] args)
        {
            Console.Clear();

            var dateTime = DateTime.UtcNow;
            var utcDate = DateTime.UtcNow;

            Console.WriteLine(dateTime);
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(utcDate.ToLocalTime());

            var timezoneAustralia =
            TimeZoneInfo.FindSystemTimeZoneById("Pacific/Auckland");
            Console.WriteLine(timezoneAustralia);

            var horaAustralia =
                TimeZoneInfo.ConvertTimeFromUtc(utcDate, timezoneAustralia);
            Console.WriteLine(horaAustralia);

            var timezones = TimeZoneInfo.GetSystemTimeZones();
            foreach (var timezone in timezones)
            {

                Console.WriteLine(timezone.Id);
                Console.WriteLine(timezone);
                Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc(utcDate, timezone));
                Console.WriteLine("--------------");
            }


        }
    }
}