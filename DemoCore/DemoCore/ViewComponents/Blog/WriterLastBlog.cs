using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace DemoCore.ViewComponents.Blog
{
	public class WriterLastBlog:ViewComponent
	{
		BlogManager bm= new BlogManager(new EFBlogRepository());	
		public IViewComponentResult Invoke()
		{
			var values = bm.GetBlogListWithWriter(2);
			return View(values);
		}
	}
}
