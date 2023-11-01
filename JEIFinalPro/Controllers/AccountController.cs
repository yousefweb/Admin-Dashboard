using JEIFinalPro.Data;
using JEIFinalPro.Models.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace JEIFinalPro.Controllers
{
    public class AccountController : Controller
    {
        private FinalDbContext db;
        public AccountController(FinalDbContext _db)
        {
            db = _db;
        }
		public IActionResult Login()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Login(LoginViewModel model)
		{
			if(ModelState.IsValid)
			{
				var data = db.Users.Where(x=>x.UserName == model.UserName && x.Password == model.Password);
				if(data.Any())
				{
					HttpContext.Session.SetString("Name",data.SingleOrDefault().UserName);
					return RedirectToAction("Index","Dashboard",new { area = "Adminstrator" } );
				}
				ViewBag.err = "Invalid user or Pass";
				return View(model);
			}
			return View(model);
		}
		public IActionResult Logout()
		{
			HttpContext.Session.Clear();
			return RedirectToAction("Login");
		}
	}
}
