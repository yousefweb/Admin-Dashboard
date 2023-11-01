using System.Collections.Generic;

namespace JEIFinalPro.Models.DataModel
{
    public class CourseCategoryBlogDataModel
    {
        public IList<Course> Courses { get; set; }
        public IList<Category> Categories { get; set; }
        public IList<Blog> Blogs { get; set; }
    }
}
