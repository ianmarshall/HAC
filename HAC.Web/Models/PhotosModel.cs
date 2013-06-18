using HAC.Domain;
using System.Collections.Generic;


namespace HAC.Models
{
    public class PhotosModel
    {

        public List<PIC_CATEGORIES> Categorieses { get; set; }
        public List<PIC_IMAGES> PicImagess { get; set; }
        public int PicCount { get; set; }
        public int CatCount { get; set; }
        public PIC_IMAGES CurrentImage { get; set; }
        public PIC_CATEGORIES CurrentCategory { get; set; }
    }
}