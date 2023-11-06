using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using DemoCore.Models;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Linq;

namespace DemoCore.Controllers
{
	public class WriterController : Controller
	{
		WriterManager wm= new WriterManager(new EFWriterRepository());
		[Authorize]
		public IActionResult Index()
		{
			var usermail = User.Identity.Name;
			ViewBag.v = usermail;
			Context c= new Context();
			var writerName = c.Writers.Where(x => x.WriterEmail == usermail).Select(y => y.WriterName).FirstOrDefault();
			ViewBag.v2=writerName;
			return View();
		}

		public IActionResult WriteProfile()
		{
			return View();
		}
		[AllowAnonymous]
		public IActionResult Test()
		{
			return View();
		}
		[AllowAnonymous]
        public PartialViewResult WriterNavbarPartial()
        {
            return PartialView();
        }
		[AllowAnonymous]
        public PartialViewResult WriterFooterPartial()
        {
            return PartialView();
        }
		
		public IActionResult WriterEditProfile()
		{
			Context c=new Context();
            var usermail = User.Identity.Name;
			var writerId = c.Writers.Where(x => x.WriterEmail == usermail).Select(y => y.WriterID).FirstOrDefault();
            var writervalues = wm.TGetById(writerId);
			return View(writervalues);
		}
		[HttpPost]
		public IActionResult WriterEditProfile(Writer p)
		{
		 WriterValidation wl= new WriterValidation();
			ValidationResult result = wl.Validate(p);
			if (result.IsValid)
			{
				wm.TUpdate(p);
				return RedirectToAction("Index", "Dashboard");
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
		[AllowAnonymous]
		[HttpGet]
		public IActionResult WritterAdd()
		{
			return View();
		}

        [AllowAnonymous]
        [HttpPost]
        public IActionResult WritterAdd(AddProfileImages p)
        {
			Writer w= new Writer();
			if(p.WriterImage!=null)
			{
				var extension = Path.GetExtension(p.WriterImage.FileName);
				var newimagename = Guid.NewGuid() + extension;
				var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/WriterImagesFile/", newimagename);
				var stream= new FileStream(location,FileMode.Create);
				p.WriterImage.CopyTo(stream);
				w.WriterImage = newimagename;

			
			}
			w.WriterEmail = p.WriterEmail;	
			w.WriterAbout= p.WriterAbout;
			w.WriterName= p.WriterName;
			w.WriterPassword=p.WriterPassword;
			w.WriterStatus=true;


			wm.TAdd(w);
            return RedirectToAction("Index","Dashboard");
        }


    }
}
