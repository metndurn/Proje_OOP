using Microsoft.AspNetCore.Mvc;

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
		public IActionResult Musteriler()
		{
			ViewBag.d = cumle();
			return View();
		}
		public IActionResult Urunler()
		{
			mesajlar();
			ViewBag.t = topla();
			ViewBag.c = cevre();
			ViewBag.f = factoriel();
			return View();
		}
		public IActionResult Index()
		{
			mesajlar();
			return View();
		}
		
	}
}
