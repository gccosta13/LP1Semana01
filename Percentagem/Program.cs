using System;
using System.Xml.Resolvers;

namespace Percentagem
{
    public class Program
    {
        private static void Main(string[] args)
        {
            
            float num1 = float.Parse(Console.ReadLine());
            float num2 = float.Parse(Console.ReadLine());
            float num3 = float.Parse(Console.ReadLine()); 
            float num4 = float.Parse(Console.ReadLine());

            Console.WriteLine($"{num1:P2}\n{num2:P2}\n{num3:P2}\n{num4:P2}");
        }

        }
    }

