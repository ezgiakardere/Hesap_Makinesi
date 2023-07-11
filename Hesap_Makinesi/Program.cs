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

            while (true)
            {
                int sayi1, sayi2;


                FileStream fs = new FileStream("C:\\HesapMakinesi.txt", FileMode.Append, FileAccess.Write, FileShare.Write);
                StreamWriter sw = new StreamWriter(fs);
                DateTime bugun = DateTime.Now;
                sw.WriteLine("İşlemi " + bugun + " tarihinde yaptın.");

                Console.WriteLine("Çarpma işlemi için 1\nToplama işlemi için 2\nÇıkarma işlemi için 3\n" +
                  "Bölme işlemi için 4\nÇıkmak için -1 e basınız");
                Console.Write("Seçim yapınız: ");
               
                double islem = Convert.ToDouble(Console.ReadLine());
                if (islem == -1)
                {
                    Console.WriteLine("Çıkış yapılıyor");
                    Console.ReadKey();
                    break;
                }
                Console.WriteLine("Birinci sayıyı giriniz:");
                sayi1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("İkinci sayıyı giriniz:");
                sayi2 = Convert.ToInt32(Console.ReadLine());

              
              

                switch (islem)
                {
                    case 1:
                        sw.WriteLine("Çarpma işleminin sonucu=" + sayi1 + "*" + sayi2 + "=" + (sayi1 * sayi2));
                        Console.WriteLine(sayi1 * sayi2);
                        Console.ReadKey();

                        sw.Close();
                        break;
                    case 2:
                        sw.WriteLine("Toplama işleminin sonucu=" + sayi1 + "+" + sayi2 + "=" + (sayi1 + sayi2));
                        Console.WriteLine(sayi1 + sayi2);
                        Console.ReadKey();

                        sw.Close();
                        break;
                    case 3:
                        sw.WriteLine("Çıkarma işleminin sonucu=" + sayi1 + "-" + sayi2 + "=" + (sayi1 - sayi2));
                        Console.WriteLine(sayi1 - sayi2);
                        Console.ReadKey();

                        sw.Close();
                        break;
                    case 4:
                        sw.WriteLine("Bölme işleminin sonucu=" + sayi1 + "/" + sayi2 + "=" + (sayi1 / sayi2));
                        Console.WriteLine(sayi1 / sayi2);
                        Console.ReadKey();

                        sw.Close();
                        break;
                    case 5:
                        Console.WriteLine("Çıkış yapılıyor");
                        Console.ReadKey();
                        break;
                  
                    default:
                        Console.WriteLine("Geçersiz işlem");
                        break;

                }

                Console.WriteLine("Kayıt Eklendi.");
                Console.ReadKey();
                

            }
          
        }
    }
}

       

