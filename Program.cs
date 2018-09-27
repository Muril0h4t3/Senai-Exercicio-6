using System;

namespace senai.operadores.ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Informe o valor em real");
            decimal vr = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor em US$");
            decimal _vd = decimal.Parse(Console.ReadLine());

            decimal cv = _vd * vr;

            Console.WriteLine($"US$ {_vd} * R$ {vr} = {_vd * vr}");
        }
    }
}
