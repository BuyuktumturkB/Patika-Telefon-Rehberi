using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaTelefonRehberi
{
	public class AnaSayfa
	{

		public void Main(string[] args) 
		{
			Secenekler secenekler = new Secenekler();
			Boolean durum = true;
			while (durum) 
			{
				Console.WriteLine("********************");
				Console.WriteLine("Telefon Rehberine Hoşgediniz");
				Console.WriteLine("1-Numara Ekle");
				Console.WriteLine("2-Numara Sil");
				Console.WriteLine("3-Numara Güncelle");
				Console.WriteLine("4-Numara Sırala");
				Console.WriteLine("5-Çıkış");
				int girdi=Convert.ToInt32(Console.ReadLine());
				switch (girdi) 
				{
					case 1:
						secenekler.Ekle();
						Console.WriteLine("****************");
						break;
					case 2:
						secenekler.Sil();
						Console.WriteLine("****************");
						break;
					case 3:
						secenekler.KisiDuzenle();
						Console.WriteLine("****************");
						break;
					case 4:
						secenekler.SıralıListele();
						Console.WriteLine("****************");
						break;
					case 5:
						durum= false;
						break;
						
				}

			}
		}
	}
}
