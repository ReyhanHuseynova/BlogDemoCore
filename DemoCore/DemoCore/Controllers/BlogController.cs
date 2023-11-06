using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using ValidationResult = FluentValidation.Results.ValidationResult;

namespace DemoCore.Controllers
{
  
    public class BlogController : Controller
    {
        BlogManager bm= new BlogManager(new EFBlogRepository());    
        CategoryManager cm= new CategoryManager(new EFCategoryRepository());
        Context c = new Context();
        public IActionResult Index()
        {
            var values=bm.GetBlogListWithCategory();    
            return View(values);
        }

        public IActionResult BlogReadAll(int id)
        {
            ViewBag.i=id;  
            var values= bm.GetBlogById(id);
            return View(values);
        }
        public IActionResult BlogListByWriter()
        {
            Context c= new Context();
            var userMail = User.Identity.Name;
            var writerId=c.Writers.Where(x=>x.WriterEmail==userMail).Select(y=>y.WriterID).FirstOrDefault();
           var values= bm.GetListWithCategoryByWriterBm(writerId);
            return View(values);
        }
        [HttpGet]
        public IActionResult BlogAdd()
        {
            
            List<SelectListItem> categoryvalue = (from x in cm.GetList()
                                                  select new SelectListItem
                                                  {
                                                      Text=x.CategoryName,
                                                      Value=x.CategoryID.ToString() 
                                                  }).ToList();
            ViewBag.cv=categoryvalue;
            return View();
        }

       
        [HttpPost]
         public IActionResult BlogAdd(Blog p)
        {
            
            var userMail=User.Identity.Name;
            var writerId = c.Writers.Where(x => x.WriterEmail == userMail).Select(y => y.WriterID).FirstOrDefault();
            BlogValidator bv= new BlogValidator();
          ValidationResult result = bv.Validate(p);
            if(result.IsValid)
            {

                p.BlogStatus = true;
                p.CreateDate=DateTime.Parse(DateTime.Now.ToShortDateString());
                p.WriterID= writerId;
                bm.TAdd(p);
                return RedirectToAction("BlogListByWriter", "Blog");
            }
            else
            {
               foreach(var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName,item.ErrorMessage);  
                    return View();
                }
              
            }
            return View();

        }

        public IActionResult DeleteBlogs(int id)
        {
            var blogValue=bm.TGetById(id);
            bm.TDelete(blogValue);
            return RedirectToAction("BlogListByWriter","Blog");
        }

        [HttpGet]
        public IActionResult EditBlog(int id)
        {
            var blogValue = bm.TGetById(id);
            List<SelectListItem> categoryvalue = (from x in cm.GetList()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.CategoryName,
                                                       Value = x.CategoryID.ToString()
                                                   }).ToList();
            ViewBag.cv = categoryvalue;

            return View(blogValue);
        }
        [HttpPost]
     
        public IActionResult EditBlog(Blog blog)
        {
            var userMail = User.Identity.Name;
            var writerId=c.Writers.Where(x=>x.WriterEmail== userMail).Select(y=>y.WriterID).FirstOrDefault();
            blog.BlogStatus = true;
            blog.WriterID = writerId;
            blog.CreateDate=DateTime.Parse( DateTime.Now.ToShortDateString());
            bm.TUpdate(blog);
            return RedirectToAction("BlogListByWriter");
        }

    }
   
}
