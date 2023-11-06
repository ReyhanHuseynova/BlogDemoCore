using ClosedXML.Excel;
using DataAccessLayer.Concrete;
using DemoCore.Areas.Admin.Models;
using DocumentFormat.OpenXml.Office2010.ExcelAc;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DemoCore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ExportDynamicExcelblogList()
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Blog List");
                worksheet.Cell(1, 1).Value = "Blog ID";
                worksheet.Cell(1, 2).Value = "Blog Name";

                int blogRowCount = 2;
                foreach (var item in BlogTitleList())
                {
                    worksheet.Cell(blogRowCount, 1).Value = item.Id;
                    worksheet.Cell(blogRowCount, 2).Value = item.BlogName;
                    blogRowCount++; 
                }

                using(var stream=new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content=stream.ToArray();
                    return File(content,"application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "BlogWork.xlsx");
                }
            }
        }

        public List<BlogModel> BlogTitleList()
        {
            List<BlogModel> blogModels = new List<BlogModel>();
            using(var c=new Context())
            {
              blogModels= c.Blogs.Select(x => new BlogModel
                {
                    Id=x.BlogID,
                    BlogName=x.BlogTitle
                }).ToList();
            }
            return blogModels;
        }

        public IActionResult BlogTitleListexcel()
        {
            return View();
        }
    }
}
