using System;
namespace project
{
    class test
    {
        public static void Main()
        {
            double qiz = Convert.ToDouble(Console.ReadLine()); 
            double final = Convert.ToDouble(Console.ReadLine());
            name(qiz, final);
        }
        public static void name (double qiz,double final)
        {
            double volume = 0 / 35 * qiz + 0 / 65 * final;
            Console.WriteLine(volume);
        }
    }
}
