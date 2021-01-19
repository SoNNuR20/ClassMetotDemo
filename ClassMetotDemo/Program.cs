using System;

namespace ClassMetotDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			Musteri musteri1 = new Musteri();
			musteri1.MusteriAdi = "Gülzade";
			musteri1.MusteriSoyadi = "O....Ş";
			musteri1.Yas = 24;
			musteri1.Meslek = "Bilgisayar Mühendisi";

			Musteri musteri2 = new Musteri();
			musteri2.MusteriAdi = "Sena";
			musteri2.MusteriSoyadi = "K.....İ";
			musteri2.Yas = 24;
			musteri2.Meslek = "Ana Okulu Öğretmeni";

			Musteri musteri3 = new Musteri();
			musteri3.MusteriAdi = "Merve";
			musteri3.MusteriSoyadi = "Ç....K";
			musteri3.Yas = 28;
			musteri3.Meslek = "Çevre Mühendisi";


			Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3};

			foreach (Musteri musteri in musteriler)
			{
				Console.WriteLine(musteri.MusteriAdi + " " + musteri.MusteriSoyadi);
				Console.WriteLine(musteri.Yas);
				Console.WriteLine(musteri.Meslek);
			}

			Console.WriteLine("&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&");

			MusteriManager musteriManager = new MusteriManager();
			musteriManager.Ekle(musteri1);
			musteriManager.Ekle(musteri2);
			musteriManager.Ekle(musteri3);

			Console.WriteLine("&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&");

			musteriManager.Guncelle("Gülzade","O....Ş");
			musteriManager.Guncelle("Sena","K.....İ");
			musteriManager.Guncelle("Merve","Ç....K");

			Console.WriteLine("&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&");

			musteriManager.Sil(musteri1);
			musteriManager.Sil(musteri2);
			musteriManager.Sil(musteri3);
		}
	}
}
