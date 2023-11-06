using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace DemoCore.ViewComponents.Blog
{
    public class BlogListdashboard:ViewComponent
    {
        BlogManager bm= new BlogManager(new EFBlogRepository());    
        public IViewComponentResult Invoke()
        {
            var values = bm.GetBlogListWithCategory();
            return View(values);
        }
    }
}
