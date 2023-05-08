
using System.Diagnostics;

Stopwatch stopwatch = new Stopwatch();
CheckBoxing();
CheckUnboxing();
CheckByVal();


stopwatch.Start();
CheckByVal();
stopwatch.Stop();
Console.WriteLine("ByVal took " + stopwatch.ElapsedMilliseconds + " milliseconds");


stopwatch.Start();
CheckBoxing();
stopwatch.Stop();
Console.WriteLine("Boxing took " + stopwatch.ElapsedMilliseconds + " milliseconds");

stopwatch.Start();
CheckUnboxing();
stopwatch.Stop();
Console.WriteLine("Unboxing took " + stopwatch.ElapsedMilliseconds + " milliseconds");




static void CheckBoxing()
{
    for (int i = 0; i < 1000000; i++)
    {
        int num = 100;
        object ojb = num;
    }
}

static void CheckUnboxing()
{
    for (int i = 0; i < 1000000; i++)
    {
        object obj = 100;
        int num2 = Convert.ToInt32(obj);
    }
}

static void CheckByVal()
{
    for (int i = 0; i < 1000000; i++)
    {
        int x = 100;
        int y = x;
    }
}