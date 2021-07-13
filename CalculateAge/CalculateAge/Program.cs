using System;

namespace CalculateAge
{
    class Program
    {

        static void Main(string[] args)
        {
            Person Theresa = new Person("09-May-1997");
            ConvertToSeconds.ConvertAgeToSeconds(Theresa);
            Theresa.ConvertAgeToSeconds();

            
        }
    }
}
