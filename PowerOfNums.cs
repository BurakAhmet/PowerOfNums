using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerOfNums
{
    class PowerOfNums
    {
        static void Main(string[] args)
        {
        
        Console.WriteLine("Bir Sayının Kuvvetleri");
            Console.Write("Taban:"); 
            int taban = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kuvvet:"); 
            int kuvvet = Convert.ToInt32(Console.ReadLine());
            int sonuç = 1;
            for (int i = 0; i < kuvvet; i++)
            {
                sonuç*= taban;
            }
            Console.Write("Sonuç:" + sonuç);
            Console.ReadLine();
        }
    }
}

        
