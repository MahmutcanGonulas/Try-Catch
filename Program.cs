using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                Console.WriteLine("Sayi Giriniz ");
                int sayi=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girilen Sayi -> "+sayi);
            }
            catch (Exception ex)
            {
                
                Console.WriteLine("Hata: "+ex.Message.ToString());
            }
            finally{
                Console.WriteLine("İşlem tamamlandı");
            }
    //**************************************************
            try
            {
                //int a=int.Parse(null);
                 //int a=int.Parse("test");
                int a=int.Parse("-20000000000");
            }
            //Bos Deger için
            catch (ArgumentNullException ex)
            {
                
                Console.WriteLine("Bos deger girdin ");
                Console.WriteLine(ex);
            }
            //Veri tip uyumsuzluğu
            catch(FormatException ex){
                Console.WriteLine("Veri tipi uygun degil");
                Console.WriteLine(ex);
            }
            //Tutabileceğinden fazla değer
            catch(OverflowException ex){
                Console.WriteLine("Çok küçük nyada çok bütyük bir değer girdin");
                Console.WriteLine(ex);
            }
        }
    }
}