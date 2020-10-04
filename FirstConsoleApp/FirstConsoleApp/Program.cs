using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Typing (primitives)----------
            //String
            string firstString = "First String";
            var secondString = "Second string";
            //implicit typing, compiler determines assigned type
            var firstChar = 'A';
            //Number
            int firstInt = 5;  //32bit signed int
            var secondInt = 6;
            int bitInt = int.MaxValue;
            uint bitPosInt = uint.MaxValue; //larger number unsigned int
            short smallerNum = short.MaxValue;
            long biggerNum = long.MaxValue;
            //float
            //float pie = 3.14; Literal of type double cant be implicitly converted
            float pie = 3.14f;
            //double
            var pi = 3.14f;
            double pi2 = 3.14; //or 3.14d
                               //boolean
            bool personTruth = true;
            var thisFalse = false;

            //static class
            int.Parse("15"); //parse the string to int
            Math.Abs(-10);

            //2.5 String manipulation------------------------
            var test = " abCDefg  ";
            test.ToUpper(); //upper case 
            test.Trim(); //remove spaces
            var longString = "it was a long time, a best time";
            //longString.Trim();
            //longString.Substring(3, longString.Length-1);
            //longString.ToUpper();
            longString.Trim().Substring(3, longString.Trim().Length - 1).ToUpper().Trim();

            //2.6 String concatenation------------------------
            var stringOne = "Hello";
            var stringTwo = "World";
            var stringThree = "you suck";
            //stringOne + stringTwo + stringThree;

            //string builder
            var sb = new StringBuilder();
            sb.Append("really good");//append a new string
            sb.Append("really bad");
            sb.Append("really mediocre");
            sb.ToString();

            sb = new StringBuilder("best time");
            sb.ToString();
            sb.AppendLine("really good"); //append a new line, \r\n at the end
            sb.AppendLine("really good"); //append a new line

            //2.7 string formatter------------------------
            var city = "Toronto";
            var temperature = 10.4f;
            var currentDt = DateTime.Now;
            string.Format("welcome to {0}. The time is {1}. The temp is {2}.", city, currentDt, temperature);
            string.Format("welcome to {0}. The time is {1:t}. The temp is {2:0,0.00}.", city, currentDt, temperature);
            //checkout string.format online

            //2.8 parsing strings as number------------------------
            var test = "15,234";
            int.Parse(test.Replace(",", ""));

            int result;
            int.TryParse("15,234", out result);
            int.TryParse("15234", out result);

            //2.10 constants and enumerators
            const float pie2 = 3.14f;
            //enum weekDays { Monday=1, Tuesday, Wednesday };
            //var someDay = weekDays.Monday;

            //2.11 dates and time
            //DateTime.Now;
            var birthday = new DateTime(1944, 12, 23);
            var difference = DateTime.Now - birthday;
            var someTime = new DateTime(2018, 1, 2, 1, 23, 12);
            someTime.AddMinutes(123);
            someTime.ToFileTime(); //for file processing
        
            Console.WriteLine("Welcome to C# Essential Training Part 1!");
            Console.WriteLine("Press the enter key to exit.");
            Console.ReadLine();
        }
    }
}
