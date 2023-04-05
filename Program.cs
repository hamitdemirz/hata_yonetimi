using System;

namespace hata_yonetimi
{

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Bir sayı giriniz:");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girmis oldugunuz sayi:" + sayi);
            }
            catch(Exception ex)
            {
                Console.WriteLine{"Hata:" + ex.Message.ToString()};
            }

            finally
            {
                Console.Write("islem tamamlandi.");
            }

            try
            {
                //int a = int.Parse(null);
                int a = int.Parse("test");
                int a = int.Parse("-20000000000");
            }
            catch(ArgumentNullException ex)
            {
                Console.WriteLine("Bos deger girdiniz.");
                Console.WriteLine(ex);
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Veri tipi uygun degil");
                Console.WriteLine(ex);
            }
            catch(OverflowException ex)
            {
                Console.WriteLine("cok kucuk ya da buyuk bir deger girdiniz");
                Console.WriteLine(ex);
            }
            finally{
                Console.WriteLine("islem basariyla tamamlandi.");
            }


        }
    }
}