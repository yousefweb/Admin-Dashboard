using JEIFinalPro.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace JEIFinalPro.ViewComponents
{
    public class CourseViewComponent:ViewComponent
    {
        private FinalDbContext db;
        public CourseViewComponent(FinalDbContext _db)
        {
            db = _db;
        }
        public IViewComponentResult Invoke()
        {

            return View(db.Courses.OrderByDescending(x=>x.CourseId).Take(6));
        }
    }
}
