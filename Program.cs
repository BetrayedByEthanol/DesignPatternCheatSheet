using System;
using System.IO;

namespace DesignPatternCheatSheet
{
    public class Program
    {
        private string getSetShort { get; set; }
        public string puGetprSetShort { get => puGetprSetShort; private set => puGetprSetShort = value; }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int? canBeNUll;
            int canNOTBeNull;

            FileInfo file = new FileInfo("");

            StreamReader reader = file?.OpenText();
            //short for
            if (file != null) reader = file.OpenText(); else reader = null;

            Console.WriteLine(args[0] ?? "arguments were null");
        }

        public static int multiplyByFive(int i)
        {
            return i * 5;
        }

        public static int multiplyByFiveShort(int i) => i * 5;

        public static (int, int) returnTwoThings(int a, int b)
        {
            return (a + b, a * b);
        }

        public static int? ifShort(int? i)
        {
            i = (i > 5) ? i * 5 : 5;
            return i;
        }

        public static void ifShortWithDiscard(int i) => _ = (i > 5) ? i * 5 : 5;

        public static string ifNullCheck(string? s) => (s == "hello") ? "world" : "could be null";

        public static string ifNullCheckLong(string? s)
        {
            if (s == "hello" && s != null)
            {
                return "world";
            }
            else
            {
                return "could be null";
            }
        }

        public static string ifNotNull(string s) => s + "world" ?? "hello world";

        public static string ifNotNullLong(string s)
        {
            if (s != null)
            {
                return s + "world";
            }
            else
            {
                return "hello world";
            }
        }

        public static string ifNUll(string s) => s ?? "s was null";

        public static string ifNullThen(string s)
        {
            s ??= "new string";
            return s;
        }

        public static string swtichShort(string s)
        {
            return s switch
            {
                "hello" => "string was hello",
                "world" => "string was world",
                _ => "nope"
            };
        }

        public static string swtichShorter(string s) => s switch {
                "hello" => "string was hello",
                "world" => "string was world",
                _ => "nope"
            };

    }
}
