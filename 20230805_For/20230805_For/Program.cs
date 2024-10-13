using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230805_For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //For Döngüsü
            //Döngü yapıları adından da belli olduğu gibi koşul doğruluğu sağladığı sürece kendi kod bloğu içerisindeki komut satırlarını işleyen mekanizmadır
            //For Döngüsü 3 aşamadan oluşur
            //syntax

            //for(başlangıçdeğeri; koşul;artışmiktarı)
            //{
            //Komut satırları
            //Komut Satırları
            //}

            //1)Uygulama for döngüsüne girdiğinde başlangıçdeğeri çalışır.Bu aşamada bir değişken tanımlama ve değişkene değer atama işlemi uygulanır

            //2)Başlagıçdeğeri çalıştıktan sonra koşul doğruluğu sorgulanır.Koşul sonucu boolean tipinde geri döner(True veya False).Sonuç "True " geri dönüyorsa for döngüsü içerisindeki komut satırları çalışır

            //3)artışmiktarı çalıştıktan sonra , başlangıç değerimizi artışmiktarına göre arttırır ve tekrardan koşul doğruluğu sorgulanır

            //Ornek1
            //1'den 10'a kadar olan olan sayıları ekrana yazdıralım
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }



            Console.ReadKey();
        }
    }
}
