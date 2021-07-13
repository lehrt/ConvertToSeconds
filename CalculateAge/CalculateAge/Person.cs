using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateAge
{
    class Person
    {
        public string BirthDate {get; set;}

        public Person(string birthday)
        {
            this.BirthDate = birthday;
        }

        public void ConvertAgeToSeconds()
        {
            DateTime birthday = DateTime.Parse(this.BirthDate);
            DateTime now = DateTime.Now;
            TimeSpan t = now - birthday;
            int total = (int)t.TotalDays;
            int seconds = total * 86400;
            Console.WriteLine($"Your birthday is {this.BirthDate}, which means you are {seconds} seconds old!");

        }
    }
}
