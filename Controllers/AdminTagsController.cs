using BlogSite.Data;
using BlogSite.Models.Domain;
using BlogSite.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BlogSite.Controllers
{
    public class AdminTagsController : Controller
    {
        private readonly BlogSiteDBContext _blogSiteDBContext;
        public AdminTagsController(BlogSiteDBContext blogSiteDBContext)
        {
            this._blogSiteDBContext = blogSiteDBContext;
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [ActionName("Add")]
        public IActionResult Add(AddTagRequest addTagRequest)
        {

            Tag tag = new Tag()
            {
                Name = addTagRequest.Name,
                DisplayName = addTagRequest.DisplayName
            };

            _blogSiteDBContext.Tags.Add(tag);
            _blogSiteDBContext.SaveChanges();

            return View("Add");
        }
    }
}
