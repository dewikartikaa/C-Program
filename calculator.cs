using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class Program
    {

        static void Main(string[] args)
        {
            float result = 0;
            
            Console.WriteLine("Masukan angka pertama");
            float angka1 = float.Parse(Console.ReadLine());

            
            Console.WriteLine("Masukan angka kedua");
            float angka2 = float.Parse(Console.ReadLine());

            
            Console.WriteLine("Masukan Operator (+,-,*./)");
            string oper = Console.ReadLine();

            switch (oper)
            {

                case "+":
                    result = angka1 + angka2;
                    break;
                case "-":
                    result = angka1 - angka2;
                    break;
                case "*":
                    result = angka1 * angka2;
                    break;
                case "/":
                    result = angka1 / angka2;
                    break;
               
            }
            Console.WriteLine("Jawaban = " + result);
            Console.Write("Tekan sembarang untuk keluar...");
            Console.ReadKey();
        }
    }
    
}