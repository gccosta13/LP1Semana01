using System;

namespace ManyStrings
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string var_1 = "teste";
            string var_2 = "teste \u225B";
            string var_3 = "teste \n";
            string var_4 = "teste \t";
            string conca = "teste" + 1;
            int numero = 1;
            string inter = $"teste {numero}";
             


            Console.WriteLine(var_1);
            Console.WriteLine(var_2);
            Console.WriteLine(var_3);
            Console.WriteLine(var_4);
            Console.WriteLine(conca);
            Console.WriteLine(inter);

            double xx = 1.23456;
            int ii = 19;

            string dprim=$"{xx:f2}";
            string dseg=$"{xx:p1}";
            string iprim=$"{ii:X}";
            string iseg=$"{ii:C}";
            


        }
    }
}
