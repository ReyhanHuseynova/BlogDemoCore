using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace DemoCore.Controllers
{
	public class RegisterController : Controller
	{
		WriterManager wm = new WriterManager(new EFWriterRepository());
		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Index(Writer p)
		{
			WriterValidation wv = new WriterValidation();
			ValidationResult result= wv.Validate(p);
			if(result.IsValid)
			{
				p.WriterStatus = true;
				p.WriterAbout = "Test";
				wm.TAdd(p);
				return RedirectToAction("Index", "Blog");
			}
			else
			{
				foreach (var item in result.Errors)
				{
					ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
				}
			}
			return View();

		}
	}
}

