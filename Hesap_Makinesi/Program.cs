using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Hesap_Makinesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
        int sayi1, sayi2;

            double sonuc;
            string islem;
            FileStream fs = new FileStream("C:\\HesapMakinesi.txt", FileMode.Append, FileAccess.Write, FileShare.Write);
            StreamWriter sw = new StreamWriter(fs);
            DateTime bugun = DateTime.Now;
            sw.WriteLine("İşlemi " + bugun + " tarihinde yaptın.");

            Console.WriteLine("Birinci sayıyı giriniz:");
            sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("İkinci sayıyı giriniz:");
            sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Çarpma işlemi için 1\nToplama işlemi için 2\nÇıkarma işlemi için 3\n" +
                "Bölme işlemi için 4");
            islem = Console.ReadLine();
            
                if (islem == "1")
                {
                    sonuc = sayi1 * sayi2;
                    sw.WriteLine("Çarpma işleminin sonucu:" + sonuc);
                Console.WriteLine(sonuc);
                    Console.ReadKey();
                
                sw.Close();
                }
                if (islem == "2")
                {
                    sonuc = sayi1 + sayi2;
                    sw.WriteLine("Toplama işleminin sonucu:" + sonuc);
                Console.WriteLine(sonuc);
                Console.ReadKey();
                sw.Close();
                }
                if (islem == "3")
                {
                    sonuc = sayi1 - sayi2;
                    sw.WriteLine("Çıkarma işleminin sonucu:" + sonuc);
                Console.WriteLine(sonuc);
                Console.ReadKey();
                sw.Close();
                }
            if (islem == "4")
            {
                if (sayi1 == 0 && sayi2 == 0)
                {
                    sw.WriteLine("Bölmenin sonucu :Belirsiz");
                    Console.ReadKey();
                    sw.Close();
                }
                else if (sayi2 == 0)
                {
                    sw.WriteLine(" Bölmenin sonucu:Tanımsız");
                    Console.ReadKey();
                    sw.Close();
                }
                else
                {
                    sonuc = sayi1 / sayi2;
                    sw.WriteLine("Bölme işleminin sonucu:" + sonuc);
                    Console.WriteLine(sonuc);
                    Console.ReadKey();
                    sw.Close();
                }
            }
        }

        }
}
