using Microsoft.AspNetCore.Mvc;
using Proje_OOP.Entity;
using Proje_OOP.ProjeContext;

namespace Proje_OOP.Controllers
{
	public class CustomerController : Controller
	{
		OopContext context = new OopContext();
		public IActionResult Index()//listeleme metodu
		{
			var values = context.Customers.ToList();
			return View(values);
		}
		[HttpGet]
		public IActionResult AddCustomer()//ekleme metodu ama sadece sayfa yuklendiğinde calısacak
		{
			return View();
		}
		[HttpPost]
		public IActionResult AddCustomer(Customer c)//ekleme metodu gercek ekleme islemi yapıldıgında calısacak
		{
			/*sartlı mesaj gosterdık yanı ters gıen bır sey olursa gerı donus yapıp baksın dıye*/
			if(c.Name.Length>=6&& c.City != "" && c.City.Length >= 3)
			{
				context.Add(c);
				context.SaveChanges();
				return RedirectToAction("Index");
			}
			else
			{
				ViewBag.message = "Lütfen bilgileri kontrol ediniz.";
				return View();
			}
		}
		public IActionResult DeleteCustomer(int id)//silme metodu id ile parametre alıp bulduk
		{
			var value = context.Customers.Where(x=>x.Id==id).FirstOrDefault();
			context.Remove(value);
			context.SaveChanges();
			return RedirectToAction("Index");
		}
		[HttpGet]
		public IActionResult UpdateCustomer(int id)//güncelleme metodu ama sadece sayfa yuklendiğinde calısacak
		{
			var value = context.Customers.Where(x => x.Id == id).FirstOrDefault();
			return View(value);
		}
		[HttpPost]
		public IActionResult UpdateCustomer(Customer c)//güncelleme metodu gercek güncelleme islemi yapıldıgında calısacak
		{
			if (c.Name.Length >= 6 && c.City != "" && c.City.Length >= 3)
			{
				var value = context.Customers.Find(c.Id);
				value.Name = c.Name;
				value.City = c.City;
				context.SaveChanges();
				return RedirectToAction("Index");
			}
			else
			{
				ViewBag.message = "Lütfen bilgileri kontrol ediniz.";
				return View();
			}
		}
	}
}
