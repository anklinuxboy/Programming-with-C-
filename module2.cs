using System;

namespace LoopTest
{
class Loops
{
    static void Main(string[] args)
    {
        string OX = "OX";
        string XO = "XO";
        for (int i = 0; i < 8; i++)
        {
        for (int j = 0; j < 4; j++)
        {
        if (i%2 == 0)
        {
        Console.Write(XO);
        } else
        {
        Console.Write(OX);
        }
        }
        Console.WriteLine();
        }
        Console.ReadKey();
        }
    }
}