using DesignPatternCheatSheet.Chain;
using DesignPatternCheatSheet.State;
using System;
using System.Collections.Generic;
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
            string arr = null;

            int? canBeNUll;
            int canNOTBeNull;
            
            FileInfo file = null;
            //file = new FileInfo("");

            StreamReader reader = file?.OpenText();
            //short for
            if (file != null) reader = file.OpenText(); else reader = null;

            Console.WriteLine(arr ?? "string was null");

            Action<int> actionWithParam = delegate (int i)  {  multiplyByFive(i); };
            actionWithParam.Invoke(5);
            Action voidAction = new Action(doesSomething);
            voidAction.Invoke();

            Predicate<string> halloFinder = (string s) => { return s == "hallo"; };
            List<string> words = new List<string>();
            string hallo;
            if (words.Count > 0) hallo =  words.Find(halloFinder);
            if (words.Count > 0) hallo = words.Find((string s) => { return s == "hallo"; });
            bool b = halloFinder("world");

            delegateFunction delegateFunction = new delegateFunction(multiplyByFive);
            delegateFunction += multiplyByFiveShort;
            int rVal = delegateFunction(2);
            Console.WriteLine("Delegate result: " + rVal);

            Func<int, string> funcShort = i => "Int was " + i;
            List<int> numberList = new List<int>();
            if (numberList.Count > 0) foreach (int i in numberList) Console.WriteLine(funcShort(i));

            Func<int, int> multFiveFunction = new Func<int, int>(multiplyByFive);
            int res = multFiveFunction(1);
            Console.WriteLine("Function result: " + res);

            Console.WriteLine("method returns: " + methodAsPara(res, randomName => { return randomName * 2; }));

            ChainExample example = new ChainExample();
            example.test();
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

        public static void doesSomething() { }
        public delegate int delegateFunction(int i);

        public static int methodAsPara(int para, Func<int,int> func) => func(para);
    }
}
