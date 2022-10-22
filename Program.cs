using System;

namespace c
{
    class Program
    {
        static void Main(string[] args)
        {
            byte a = 1;
            sbyte b = 2;
            short c = 3;
            long d = a+b+c;
            float e = d+a+b+c;
            string f = "test";
            char g = '5';
            
            int x = a+b+c;
            object z = f+g;

            byte Ca = (byte)e;
            string Cb = a.ToString();
            int Cc = Convert.ToInt32(g);

            Console.WriteLine(x);
            Console.WriteLine(z);
            Console.WriteLine(Ca);
            Console.WriteLine(Cb);
            Console.WriteLine(Cc+a);
            Parse("4","4");

  

        }
        public static void Parse(string Pa,string Pb)
        {
            int newPa = Convert.ToInt32(Pa);
            int newPb = Convert.ToInt32(Pb);
            Console.WriteLine(newPa+newPb);

        }
    }
}