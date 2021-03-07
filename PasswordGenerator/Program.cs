using System;
using System.Linq;
using System.Text;
namespace PasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {

            StringBuilder str_build = new StringBuilder();
            

            Console.WriteLine("Welcome to The Password Generator Program");
            Console.WriteLine("Press 1 if you would like to AutoGenerate Your Password OR Press 2 for Advance AutoGenerate Feature :  ");
            string Userinput = Console.ReadLine();
            int UserInputInNumber = Convert.ToInt32(Userinput);
            if (UserInputInNumber == 1)
            {
                Console.WriteLine("How Many Charater your want your password to be: ");
                int HowLong = Convert.ToInt32(Console.ReadLine());
                RandomNumber(HowLong);
            } else if (UserInputInNumber == 2)
            {
                Console.WriteLine("Welcome to Advance Menu: ");
                Console.WriteLine("How Many Numbers you want: ");
                int Numbers = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("How Many Lower Case Letter you want: ");
                int lcletter = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("How Many Upper Case Letter you want: ");
                int ucletter = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("How Many Special Character you want: ");
                int spword = Convert.ToInt32(Console.ReadLine());
                advanceinput(Numbers, lcletter, ucletter, spword);
            }
            else
            {
                Console.WriteLine("<<< WORNG INPUT >>> PROGRAME CLOSING ...... TRY AGAIN >>>>>");
            }
        }

        public static void RandomNumber(int HowLong)
        {
            StringBuilder str_build = new StringBuilder();
            Random r = new Random();
            int divded = (HowLong / 3);
            for (int i = 1; i < divded; i++)
            {

                int RandomNumber = r.Next(0, 9);
                str_build.Append(RandomNumber);
            }
            for (int i = 0; i < divded; i++)
            {
                char RandomChar = (char)r.Next('a','z');
                RandomChar.ToString();
                str_build.Append(RandomChar);
            }
            for (int i = 0; i < divded; i++)
            {
                char RandomChar = (char)r.Next('A', 'Z');
                RandomChar.ToString();
                str_build.Append(RandomChar);
            }
            for (int i = 0; i < 1; i++)
            {
                char[] aa = { '@', '#', '!', '_', '%' };
                int randomnumber = r.Next(0, 5);
                str_build.Append(aa[randomnumber]);
            }
            string a = str_build.ToString();
            
            Console.WriteLine($"Your Password can be: {shuffle(a)}");
        }


        static string shuffle(string input)
        {
            var q = from c in input.ToCharArray()
                    orderby Guid.NewGuid()
                    select c;
            string s = string.Empty;
            foreach (var r in q)
                s += r;
            return s;
        }


        public static void advanceinput(int Numbers, int lcletter, int ucletter, int spword )
        {
            StringBuilder str_build = new StringBuilder();
            Random r = new Random();
            for (int i = 1; i < Numbers; i++)
            {

                int RandomNumber = r.Next(0, 9);
                str_build.Append(RandomNumber);
            }
            for (int i = 0; i < lcletter; i++)
            {
                char RandomChar = (char)r.Next('a', 'z');
                RandomChar.ToString();
                str_build.Append(RandomChar);
            }
            for (int i = 0; i < ucletter; i++)
            {
                char RandomChar = (char)r.Next('A', 'Z');
                RandomChar.ToString();
                str_build.Append(RandomChar);
            }
            for (int i = 0; i < spword; i++)
            {
                char[] aa = { '@', '#', '!', '_', '%' };
                int randomnumber = r.Next(0, 5);
                str_build.Append(aa[randomnumber]);
            }
            string a = str_build.ToString();

            Console.WriteLine($"Your Password can be: {shuffle(a)}");
        }


    }
}

