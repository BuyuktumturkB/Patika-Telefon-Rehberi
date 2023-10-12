using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaTelefonRehberi
{
	public class Kisi
	{
		private string ad;
		private string soyad;
		private string numara;

		public Kisi(string Ad,string Soyad, string Numara) 
		{
			this.ad = Ad;
			this.soyad = Soyad;
			this.numara = Numara;

		}
		public string Ad { get=>ad; set=>ad = value; }
		public string Soyad { get=>soyad; set=>soyad = value; }
		public string Numara { get=>numara; set=>numara = value; }

	}
}
