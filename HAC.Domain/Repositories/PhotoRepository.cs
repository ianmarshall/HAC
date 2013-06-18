using System.Collections.Generic;
using System.Linq;

namespace HAC.Domain.Repositories
{
    public class PhotoRepository
    {
        private HAC2CeEntities context = new HAC2CeEntities();

        public void Save(PIC_IMAGES image)
        {
            context.PIC_IMAGES.Add(image);
            context.SaveChanges();
        }
        public void Save(PIC_CATEGORIES category)
        {
            context.PIC_CATEGORIES.Add(category);
            context.SaveChanges();
        }
        public PIC_IMAGES GetImage(int id)
        {
            return context.PIC_IMAGES.FirstOrDefault(p => p.PIC_ID == id);
        }

        public int GetImagesCount()
        {
            return context.PIC_IMAGES.Count();
        }

        public int GetCategoriesCount()
        {
            return context.PIC_CATEGORIES.Count();
        }

        public List<PIC_CATEGORIES> GetCategories()
        {
            return context.PIC_CATEGORIES.OrderByDescending(c => c.CAT_ID).ToList();
        }

        public List<PIC_IMAGES> GetCategoryImages(int catId)
        {
            return context.PIC_IMAGES.Where(i => i.PIC_CAT == catId).ToList();
        }
    }

}
