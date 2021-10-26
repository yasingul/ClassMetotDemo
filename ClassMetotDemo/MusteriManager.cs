using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    public class MusteriManager
    {
        public void MusteriEkle(Musteri musteri) 
        {
            Console.WriteLine("Tebrikler, " + musteri.Adi);
            Console.WriteLine("Sisteme Kaydınız Başarılı Bir Şekilde Yapıldı!");
        }
        
        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi + " Sistemden Silindi!");
        }
    }
}
