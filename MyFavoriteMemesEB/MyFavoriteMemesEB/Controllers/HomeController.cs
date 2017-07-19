using MyFavoriteMemesEB.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace MyFavoriteMemesEB.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var model = new HomeViewModel()
            {
                MemeList = new List<Models.ImageModel>
                {
                    new Models.ImageModel
                    {
                        MemeId = 1,
                        ImageUrl = "http://i.dailymail.co.uk/i/pix/2016/03/18/15/324D202500000578-3498922-image-a-33_1458315465874.jpg"
                    },

                    new Models.ImageModel
                    {
                        MemeId = 2,
                        ImageUrl = "http://i.dailymail.co.uk/i/pix/2016/03/18/15/324D202500000578-3498922-image-a-33_1458315465874.jpg"
                    },
                    new Models.ImageModel
                    {
                        MemeId = 3,
                        ImageUrl = "http://i.dailymail.co.uk/i/pix/2016/03/18/15/324D202500000578-3498922-image-a-33_1458315465874.jpg"
                    }
                }
            };

            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}