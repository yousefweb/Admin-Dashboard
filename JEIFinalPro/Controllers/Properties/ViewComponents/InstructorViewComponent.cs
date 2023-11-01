using JEIFinalPro.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace JEIFinalPro.ViewComponents
{
    public class InstructorViewComponent : ViewComponent
    {
        private FinalDbContext db;
        public InstructorViewComponent(FinalDbContext _db)
        {
            db = _db;
        }
        public IViewComponentResult Invoke()
        {
            return View(db.Instructors.OrderByDescending(x => x.CreationDate).Take(10));
        }
    }
}
