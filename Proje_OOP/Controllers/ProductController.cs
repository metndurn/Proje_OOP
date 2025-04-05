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
		public IActionResult AddProduct(Product p)//ekleme metodu
		{
			if (ModelState.IsValid)
			{
				context.Products.Add(p);//veritabanına ekle
				context.SaveChanges();//değişiklikleri kaydet
				return RedirectToAction("Index");
			}
			return View();
		}
	}
}
