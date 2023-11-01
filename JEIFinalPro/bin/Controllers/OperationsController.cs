using JEIFinalPro.Data;
using JEIFinalPro.Models.DataModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace JEIFinalPro.Controllers
{
    public class OperationsController : Controller
    {
        public FinalDbContext db;
        public OperationsController(FinalDbContext _db)
        {
            db = _db;
        }
        public IActionResult Index()
        {
            CourseCategoryBlogDataModel model = new CourseCategoryBlogDataModel
            { 
              Blogs = db.Blogs.ToList(),
              Categories = db.Categories.ToList(),
              Courses = db.Courses.OrderByDescending(x =>x.CourseId).Take(5).ToList()
              
            };
            return View(model);
        }

        public IActionResult BlogDetails(Guid id)
        {
            return View(db.Blogs.Find(id));
        }
    }
}
