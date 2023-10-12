using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaTelefonRehberi
{
	public class Secenekler
	{
		List<Kisi> Kişiler = new List<Kisi>();
		public Secenekler()
		{
			Kişiler.Add(new Kisi("Ali", "Bilir", "08452211467"));
			Kişiler.Add(new Kisi("Alim", "Zengin", "05453432566"));
			Kişiler.Add(new Kisi("Afize", "Karmaz", "0842211467"));
			Kişiler.Add(new Kisi("Vecdet", "Güner", "05453322566"));
			Kişiler.Add(new Kisi("Kasım", "Kerim", "084522114621"));
			Kişiler.Add(new Kisi("Yusuf", "Fahir", "05453432326"));
		}
		public void Ekle()
		{
			Console.WriteLine("Ad Giriniz");
			string isim = Console.ReadLine(); isim = isim.ToUpper();
			Console.WriteLine("Soyad Giriniz");
			string soyisim = Console.ReadLine(); soyisim = soyisim.ToUpper();
			Console.WriteLine("Telefon Numarasını Giriniz");
			String telno = Console.ReadLine();

			Kisi kisi = new Kisi(isim, soyisim, telno);
			Kişiler.Add((kisi));
			Console.WriteLine(isim + "Baarı ile Kaydedilmiştir.");
		}
		public void Arama()
		{
			Console.WriteLine("Lütfen ad ve soyad giriniz");
			string isim_soyisim = Console.ReadLine(); isim_soyisim = isim_soyisim.ToUpper();
			for (int i = 0; i < Kişiler.Count; i++)
			{
				if (Kişiler[i].Ad == isim_soyisim || Kişiler[i].Soyad == isim_soyisim)
				{
					Console.WriteLine("Kişinin adı: " + Kişiler[i].Ad);
					Console.WriteLine("Kişinin adı: " + Kişiler[i].Soyad);
					Console.WriteLine("Kişinin adı: " + Kişiler[i].Numara);
				}
				if (i == Kişiler.Count - 1)
				{
					Console.WriteLine("Kişi Verisi Bulunamadı");
				}
			}
		}
		public void Sil()
		{

		baslangic:
			Console.WriteLine("Lütfen Silmek istediğniz kişi için isim-soyisim giriniz");
			string isim_soyisim = Console.ReadLine(); isim_soyisim = isim_soyisim.ToUpper();
			for (int i = 0; i < Kişiler.Count; i++)
			{
				if (Kişiler[i].Ad == isim_soyisim || Kişiler[i].Soyad == isim_soyisim)
				{
					Console.WriteLine(Kişiler[i].Ad + " isimli kişi silinecektir emin misiniz?");
					Console.WriteLine("Evet 1" + "Hayır 2");
					int kontrol = Convert.ToInt32(Console.ReadLine());
					if (kontrol == 1)
					{
						Console.WriteLine(Kişiler[i].Ad + Kişiler[i].Soyad + " Kişisi Silinmiştir");
						Kişiler.RemoveAt(i);
						break;
					}
					if (kontrol == 2)
					{
						Console.WriteLine("Silinme işlemi iptal edilmiştir");
						break;
					}
					else
						break;
				}
				if (i == Kişiler.Count - 1)
				{
					Console.WriteLine("Kişi Verisi Bulunamadı");
					Console.WriteLine("Tekrar Denemek için 1 i iptal etmek için 2 yi seçiniz");
					int kontrol = Convert.ToInt32(Console.ReadLine());
					if (kontrol == 1)
					{
						goto baslangic;
					}
					if (kontrol == 2)
					{
						Console.WriteLine("İşlem iptal edilmiştir");
					}
				}

			}

		}
		public void KisiDuzenle()
		{
		baslangıc:
			Console.WriteLine("Lütfen ad ve soyad giriniz");
			string isim_soyisim = Console.ReadLine(); isim_soyisim = isim_soyisim.ToUpper();
			for (int i = 0; i < Kişiler.Count; i++)
			{
				if (Kişiler[i].Ad == isim_soyisim || Kişiler[i].Soyad == isim_soyisim)
				{
					Console.WriteLine("Seçenekler;");
					Console.WriteLine("1- Ad Düzenle\n " + " 2 Soyad Düzenle\n" + "3 Numara Düzenle \n " + "4 İptal ");
					int girdi = Convert.ToInt32(Console.ReadLine());
					if (girdi == 1)
					{
						Console.WriteLine("Lütfen Yeni isim giriniz"); string yeniad = Console.ReadLine(); yeniad = yeniad.ToUpper();
						Console.WriteLine(Kişiler[i].Ad + " olarak " + yeniad + "düzenlenmiştir");
						Kişiler[i].Ad = yeniad;
						break;
					}
					else if (girdi == 2)
					{
						Console.WriteLine("Yeni Soyadı Yazınz");
						string yenisoyad = Console.ReadLine(); yenisoyad = yenisoyad.ToUpper();
						Console.WriteLine(Kişiler[i].Soyad + " olarak " + yenisoyad + "düzenlenmiştir");
						Kişiler[i].Soyad = yenisoyad;
						break;

					}
					else if (girdi == 3)
					{
						Console.WriteLine("Yeni Numarayı Giriniz"); string yeninumara = Console.ReadLine();
						Console.WriteLine(Kişiler[i].Numara + " olarak " + yeninumara + "düzenlenmiştir");
						Kişiler[i].Numara = yeninumara;
						break;

					}
					else
						break;
				}
				if (i == Kişiler.Count - 1)
				{
					Console.WriteLine("Kişi Verisi Bulunamadı");
					Console.WriteLine("Tekrar Denemek için 1 i iptal etmek için 2 yi seçiniz");
					int kontrol = Convert.ToInt32(Console.ReadLine());
					if (kontrol == 1)
					{
						goto baslangıc;
					}
					if (kontrol == 2)
					{
						Console.WriteLine("İşlem iptal edilmiştir");
					}

				}



			}
		}

		public void SıralıListele()
		{
			var kisiliste = Kişiler.OrderBy(value => value.Ad);
			foreach (var i in kisiliste)
			{
				Console.WriteLine("********************");
				Console.WriteLine("İsim:" + i.Ad);
				Console.WriteLine("Soysim:" + i.Soyad);
				Console.WriteLine("Numara" + i.Numara);
				Console.WriteLine("********************");
			}
		}

	}
}
