using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;

namespace DemoCore.Controllers
{
	public class CommentController : Controller
	{
		CommentManager cm = new CommentManager(new EFCommentRepository());
		public IActionResult Index()
		{
			return View();
		}
		[HttpGet]
		public PartialViewResult PartialComment()
		{
			return PartialView();	
		}
		[HttpPost]
		public PartialViewResult PartialComment(Comment p)
		{
			p.CommentDate=DateTime.Parse(DateTime.Now.ToShortDateString());
			p.CommentStatus = true;
			p.BlogID = 1;
			cm.CommentAdd(p);
			return PartialView();
		}

		public PartialViewResult CommentListByBlog(int id)
		{
		 var values= cm.GetList(id);
			return PartialView(values);
		}
	}
}
