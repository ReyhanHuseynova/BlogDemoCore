using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace DemoCore.Controllers
{
	public class LoginController : Controller
	{
		[AllowAnonymous]
		public IActionResult Index()
		{
			return View();
		}
		[HttpPost]
		[AllowAnonymous]
		public async Task<IActionResult> Index(Writer p)
		{
			Context c = new Context();
			var datavalues = c.Writers.FirstOrDefault(x => x.WriterEmail == p.WriterEmail &&
			x.WriterPassword == p.WriterPassword);
			if (datavalues != null)
			{
				var claims = new List<Claim>
				{
					new Claim(ClaimTypes.Name,p.WriterEmail)
				};
				var userIdentity= new ClaimsIdentity(claims,"a");
				ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
				await HttpContext.SignInAsync(principal);
				return RedirectToAction("Index", "Dashboard");
			}
			else
			{
				return View();
			}
		}
	}
}
//Context c = new Context();
//var datavalues = c.Writers.FirstOrDefault(x => x.WriterEmail == p.WriterEmail && x.WriterPassword == p.WriterPassword);
//if (datavalues != null)
//{
//	HttpContext.Session.SetString("username", p.WriterEmail);
//	return RedirectToAction("Index", "Writer");
//}
//else
//{
//	return View();
//}