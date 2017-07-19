using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace MyFavoriteMemesEB.Models
{
    public class ImageModel
    {
        public int MemeId { get; set; }
        public string ImageUrl { get; set; }
    }

    public class MemeModel
    {
        public int MemeId { get; set; }
        public string ImageUrl { get; set; }
        [DisplayName("Top Text")]
        public string TopText { get; set; }
        [DisplayName("Bottom Text")]
        public string BottomText { get; set; }
    }

}