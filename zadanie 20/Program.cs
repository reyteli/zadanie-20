using System;

namespace zadanie_20
{
    class Program
    {
        delegate double Mydelegate(double r);
        static void Main(string[] args)
        {
            Mydelegate mydelegate = Dlina;
            double s = mydelegate(5);
            Console.WriteLine(s);
           
            mydelegate = Ploshad;
            s = mydelegate(7);
            Console.WriteLine(s);

            mydelegate = Obem;
            s = mydelegate(9);
            Console.WriteLine(s);
            Console.ReadKey();

        }
        static double Dlina(double r) => 2 * r * Math.PI;
        static double Ploshad(double r) => r * r * Math.PI;
        static double Obem(double r) => 4 / 3 * r * r * r * Math.PI;
    }
}
