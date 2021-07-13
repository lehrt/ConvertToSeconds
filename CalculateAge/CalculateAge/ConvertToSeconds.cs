using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateAge
{
    class ConvertToSeconds
    {
        public static void ConvertAgeToSeconds(Person person)
        {
            DateTime birthday = DateTime.Parse(person.BirthDate);
            DateTime now = DateTime.Now;
            TimeSpan t = now - birthday;
            int total = (int)t.TotalDays;
            int seconds = total * 86400;
            Console.WriteLine($"Your birthday is {person.BirthDate}, which means you are {seconds} seconds old!");
        }


    }
}
