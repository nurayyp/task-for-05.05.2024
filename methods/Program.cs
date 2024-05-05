//using System;
//using System.Collections.Specialized;
//using System.ComponentModel;
//using System.Diagnostics.CodeAnalysis;
//using System.Diagnostics.Tracing;
//using System.Text;
//namespace Test
//{
//    public static class Program
//    {
        //1
        //public static void Main(string[] args)
        //{
        //    int num = MultipleNumbers(3,4);
        //    Console.WriteLine(num);
        //}
        //public static int MultipleNumbers(int a, int b)
        //{
        //   return a + b;
        //}

        //2
        //public static void Main(string[] args)
        //{
        //    int num = FindSquare(5);
        //    Console.WriteLine(num );
        //}
        //public static int FindSquare( int n )
        //{
        //    return n * n;
        //}

        //3
        //public static void Main(string[] args)
        //{
        //    int sum1 = SumArray([1,2,4]);
        //    Console.WriteLine(sum1);
        //}
        //public static int SumArray(int[] array)
        //{
        //    int sum = 0;
        //    for (int i = 0; i < array.Length; i++)
        //    {

        //        sum += array[i];

        //    }
        //    return sum;
        //}

        //4
        //public static void Main(string[] args)
        //{
        //    WelcomeMessage("Nuray", "Pashayeva");
        //}
        //public static void WelcomeMessage(string name, string surname)
        //{
        //    Console.WriteLine($"xos gelmisiniz {name} {surname}");
        //}

        //5
        //public static void Main(string[] args)
        //{
        //    string word = "Salam";
        //    Console.WriteLine(ReverseWordWithSB(word));
        //}
        //public static StringBuilder ReverseWordWithSB(string word)
        //{
        //    StringBuilder reversedWord = new StringBuilder();
        //    for (int i = word.Length - 1; i >= 0; i--)
        //    {
        //        reversedWord.Append(word[i]);

        //    }
        //    return reversedWord;
        //}

        //6
        //public static void Main(string[] args)
        //{
        //    GiveNumber(65);
        //}
        //public static void GiveNumber(int a)
        //{
        //    if (a % 7 == 0)
        //    {
        //        Console.WriteLine($"{a} ededi 7-e bolunur");
        //    }
        //    else
        //    {
        //        int num = a / 7;
        //        int x = 7 * num;
        //        int y = 7 * (num+1);
        //        if (y - a>a - x)
        //        {
        //            Console.WriteLine($"{x}");
        //        }
        //        else
        //        {
        //            Console.WriteLine($"{y}");
        //        }
        //    }
        //}

        //7
        //public static void Main(string[] args)
        //{
        //    Console.WriteLine( perimeter(3,6,8));
        //}
        //public static int perimeter(int a, int b, int c )
        //{
        //    return a + b + c;
        //}
        //public static int perimeter(int a)
        //{
        //    return 4 * a;
        //}

        //11
        //public static void Main(string[] args)
        //{
        //    Console.WriteLine(SentenceSpace("Bu gun hava guneslidir"));
        //}
        //public static int SentenceSpace(string text)
        //{
        //    int count = 0;
        //    for (int i = 0; i < text.Length; i++)
        //    {
        //        if (text[i] == ' ')
        //        {
        //            count++;
        //        }
        //    }
        //    return count;
        //}
//    }
//}