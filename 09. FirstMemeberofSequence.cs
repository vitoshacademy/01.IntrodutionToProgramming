using System;
class First10MembersOfSequence
{
    static void Main()
    {
        for (int i = 2; i < 12; i++)
        {
            Console.Write("{0}, ", i * Math.Pow(-1, i));
            Console.WriteLine("");
        }
    }
}
