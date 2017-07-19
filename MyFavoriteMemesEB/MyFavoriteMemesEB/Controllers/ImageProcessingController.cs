using MyFavoriteMemesEB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFavoriteMemesEB.Controllers
{
    public class ImageProcessingController : Controller
    {
        // GET: ImageProcessing
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ProcessMeme(HomeViewModel model)
        {
            var processedMeme = new ProcessMemeViewModel()
            {
                TopText = model.SubmitMeme.TopText,
                BottomText = model.SubmitMeme.BottomText,
                ImageUrl = model.SubmitMeme.ImageUrl
            };

            return View(processedMeme);
        }
    }
}