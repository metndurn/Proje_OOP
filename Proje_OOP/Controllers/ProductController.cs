using Microsoft.AspNetCore.Mvc;
using Proje_OOP.Entity;
using Proje_OOP.ProjeContext;

namespace Proje_OOP.Controllers
{
	public class ProductController : Controller
	{
		OopContext context = new OopContext();//db context ile nesne turettik
		public IActionResult Index()
		{
			var values = context.Products.ToList();// veritabanındaki ürünleri listele
			return View(values);
		}
		/*httpget ile sayfa yuklendıgı zaman bu ekleme metodu calısır*/
		[HttpGet]
		public IActionResult AddProduct()//ekleme metodu
		{
			return View();
		}
		/*httppost ile formdan gelen veriler bu ekleme metoduna gider*/
		[HttpPost]
		public IActionResult AddProduct(Product p)//ekleme metoduna parametre eklemek sarttır
		{
			context.Add(p);//veritabanına ekle
			context.SaveChanges();//değişiklikleri kaydet
			return RedirectToAction("Index");
		}
		public IActionResult DeleteProduct(int id)//silme metodu
		{
			//veritabanından silinecek ürünü where ile parametredeki idsi esit olanı bulup silecek
			var value = context.Products.Where(x => x.Id == id).FirstOrDefault();
			context.Remove(value);//remove ile veritabanından buldugun degeri sil
			context.SaveChanges();
			return RedirectToAction("Index");
		}
		[HttpGet]//burada sayfa yuklendiğinde calısacak olan kısma verılerı gosterdık
		public IActionResult UpdateProduct(int id)//güncelleme metodu
		{
			var value = context.Products.Where(x => x.Id == id).FirstOrDefault();//veritabanından güncellenecek ürünü bul
			return View(value);
		}
		[HttpPost]//formdan gelen veriler bu güncelleme metoduna gider
		public IActionResult UpdateProduct(Product p)//güncelleme metoduna parametre eklemek sarttır
		{
			var value = context.Products.Find(p.Id);//veritabanından güncellenecek ürünü bul
			value.Name = p.Name;//güncellenen ürünün adını güncelle
			value.Price = p.Price;//güncellenen ürünün fiyatını güncelle
			value.Stock = p.Stock;//güncellenen ürünün stokunu güncelle
			context.SaveChanges();//değişiklikleri kaydet
			return RedirectToAction("Index");
		}
	}
}
