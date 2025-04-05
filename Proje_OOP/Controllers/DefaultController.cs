using Microsoft.AspNetCore.Mvc;
using Proje_OOP.Ornekler;

namespace Proje_OOP.Controllers
{
	public class DefaultController : Controller
	{
		void mesajlar()
		{
			ViewBag.m1 = "Merhaba bu bir core projesidir";
			ViewBag.m2 = "Merhaba proje cok iyi duruyor";
			ViewBag.m3 = "Merhaba selamlar hi bonjuor";
		}
		int topla()
		{
			int a = 5;
			int b = 10;
			int toplam = a + b;
			return toplam;
		}
		int cevre()
		{
			int kisakenar = 5;
			int uzunkenar = 10;
			int cevre = (kisakenar + uzunkenar) * 2;
			return cevre;
		}
		int factoriel()
		{
			int sonuc = 1;
			int sayi = 5;
			for (int i = 1; i <= sayi; i++)
			{
				sonuc *= i;
			}
			return sonuc;
		}
		string cumle()
		{
			string cumle = "Merhaba bu bir core projesidir";
			return cumle;
		}
		void MesajListesi(string p)
		{
			ViewBag.v = p;
		}
		void Kullanici(string kullaniciadi)
		{
			ViewBag.k = kullaniciadi;
		}
		int Topla(int s1,int s2)
		{
			int sonuc = s1 + s2;
			return sonuc;
		}
		int Faktoriyel(int fak)
		{
			//kısacası faktöriyel hesaplama işlemi kac adet sayı gırılse o sayıların çarpımını alır
			//6! --> 1*2*3*4
			//1*1=1
			//2*1=2
			//3*2=6
			//4*6=24
			int f = 1;
			for (int i = 1; i <= fak; i++)
			{
				f = f * i;
			}
			return f;
		}
		public IActionResult Index()
		{
			mesajlar();
			MesajListesi("Parametere ismi:");
			Kullanici("metin123");
			ViewBag.t = Topla(20, 35);
			return View();
		}
		public IActionResult Musteriler()
		{
			ViewBag.d = cumle();
			Kullanici("meryem123");
			ViewBag.faktor = Faktoriyel(6);
			return View();
		}
		public IActionResult Urunler()
		{
			mesajlar();
			ViewBag.t = topla();
			ViewBag.c = cevre();
			ViewBag.f = factoriel();
			Kullanici("halime123");
			return View();
		}
		public IActionResult City()
		{
			Sehirler sehirler = new Sehirler();// nesne oluşturma işlemi yapıldı


			//proporty'leri kullanarak nesneye değer atama işlemi yapıldı
			sehirler.Id = 1;
			sehirler.Ad = "Kiev";
			sehirler.Nufus = 15000000;
			sehirler.Ulke = "Ukrayna";
			sehirler.Renk1 = "Mavi";
			sehirler.Renk2 = "Sari";


			// nesne üzerinden viewbag'e değer atama işlemi yapıldı
			ViewBag.s1 = sehirler.Id;
			ViewBag.s2 = sehirler.Ad;
			ViewBag.s3 = sehirler.Nufus;
			ViewBag.s4 = sehirler.Ulke;
			ViewBag.s5 = sehirler.Renk1;
			ViewBag.s6 = sehirler.Renk2;
			ViewBag.s7 = sehirler.Renk3;


			sehirler.Id = 2;
			sehirler.Ad = "Ankara";
			sehirler.Nufus = 5000000;
			sehirler.Ulke = "Türkiye";
			sehirler.Renk1 = "Beyaz";
			sehirler.Renk2 = "Kırmızı";


			ViewBag.t1 = sehirler.Id;
			ViewBag.t2 = sehirler.Ad;
			ViewBag.t3 = sehirler.Nufus;
			ViewBag.t4 = sehirler.Ulke;
			ViewBag.t5 = sehirler.Renk1;
			ViewBag.t6 = sehirler.Renk2;
			ViewBag.t7 = sehirler.Renk3;
			return View();
		}
		
	}
}
