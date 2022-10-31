using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Midtap
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int x = Convert.ToInt32(Console.ReadLine());
            if (x < 51)
            {
                Console.WriteLine("Siz kesildiniz ");

            }

            else if (x <= 60)
            {
                Console.WriteLine("Siz E aldiniz");

            }
            else if (x <= 70)
            {
                Console.WriteLine("siz D aldiniz");
            }
            else if (x <= 80)
            {
                Console.WriteLine("siz C aldiniz");
            }
            else if (x <= 90)
            {
                Console.WriteLine("siz B aldiniz");
            }
            else
            {
                Console.WriteLine("siz A aldiniz");
            }

        }
    }
}
