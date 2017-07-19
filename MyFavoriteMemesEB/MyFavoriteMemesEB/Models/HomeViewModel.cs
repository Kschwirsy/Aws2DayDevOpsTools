using System.Collections.Generic;

namespace MyFavoriteMemesEB.Models
{
    public class HomeViewModel
    {
        public List<ImageModel> MemeList { get; set; }

        public MemeModel SubmitMeme { get; set; }
    }
}