using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace DemoCore.Controllers
{
	public class NewsLatterController : Controller
	{
		NewsLatterManager nm= new NewsLatterManager(new EFNewsLatterRepository());	
		public PartialViewResult SubbscribeMail()
		{
			return PartialView();
		}

		[HttpPost]
		public PartialViewResult SubbscribeMail(NewsLetter p)
		{
			p.MailStatus=true;
		    nm.AddNewsLatter(p);
			Response.Redirect("/Blog/Index/");
			return PartialView(p);
			
		}
	}
}
