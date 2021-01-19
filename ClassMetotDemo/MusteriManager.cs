using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
	class MusteriManager
	{
		public void Ekle(Musteri musteri)
		{
			Console.WriteLine(musteri.MusteriAdi + " " + musteri.MusteriSoyadi + " " + "Adlı Müşteri Eklendi");
		}

		public void Guncelle(string MusteriAdi,string MusteriSoyadi)
		{
			Console.WriteLine(MusteriAdi + " " + MusteriSoyadi + " " + "Adlı Müşteri güncellendi");
		}

		public void Sil(Musteri musteri)
		{
			Console.WriteLine(musteri.MusteriAdi + " " + musteri.MusteriSoyadi + " " + "Adlı Müşteri Silindi");
		}

		
	}
}
