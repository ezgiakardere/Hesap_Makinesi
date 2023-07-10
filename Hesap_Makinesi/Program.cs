using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hesap_Makinesi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int sayi1, sayi2;

            double sonuc;
            string islem;

            Console.WriteLine("Birinci sayıyı giriniz:");
            sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("İkinci sayıyı giriniz:");
            sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("İşlem seçiniz (+,-,/,*)");
            islem = Console.ReadLine();

            if (islem == "*")
            {
                sonuc = sayi1 * sayi2;
                Console.WriteLine("Çarpma işleminin sonucu:" + sonuc);
                Console.ReadKey();
            }
            if (islem == "+")
            {
                sonuc = sayi1 + sayi2;
                Console.WriteLine("Toplama işleminin sonucu:" + sonuc);
                Console.ReadKey();
            }
            if (islem == "-")
            {
                sonuc = sayi1 - sayi2;
                Console.WriteLine("Çıkarma işleminin sonucu:" + sonuc);
                Console.ReadKey();
            }
            if (islem == "/")
            {
                if (sayi1 == 0 && sayi2 == 0)
                {
                    Console.WriteLine("Belirsiz");
                    Console.ReadKey();
                }
                else if( sayi2 == 0)
                {
                    Console.WriteLine("Tanımsız");
                    Console.ReadKey();
                }
                else
                {
                    sonuc = sayi1 / sayi2;
                    Console.WriteLine("Bölme işleminin sonucu:" + sonuc);
                    Console.ReadKey();
                }
                
            }

        }
    }
}
