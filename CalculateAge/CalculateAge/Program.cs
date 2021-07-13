using System;

namespace CalculateAge
{
    class Program
    {

        static void Main(string[] args)
        {
            Person Theresa = new Person("09-May-1997");
            //my instance of person class

            ConvertToSeconds thing = new ConvertToSeconds();
            thing.ConvertAgeToSeconds(Theresa);
            //1. how to use non-static method over span of two classes

            ConvertToSeconds.ConvertAgeToSeconds2(Theresa);
            //2. how this looks using a static method
            
            Theresa.ConvertAgeToSeconds();
            //3. simplest, most concise method. Took ConvertAgeToSeconds method and put it right in person class, so I was able to access properties and fields of Person class without having to create instance of ConvertToSeconds.

            
        }
    }
}
