using HAC.Domain.Repositories;
using HAC.Web.Models;
using System.Linq;
using System.Web.Mvc;

namespace HAC.Web.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            EventRepository eventRepository = new EventRepository();
               PhotoRepository photoRepository = new PhotoRepository();
            AnnouncementRepository announcementRepository = new AnnouncementRepository();

            var homeModel = new HomeModel()
            {
                LatestAnnouncements = announcementRepository.GetLatestAnnouncements(4).ToList(),
                ActiveAnnouncementsCount = announcementRepository.GetActiveAnnouncements().Count(),
                LatestEvents = eventRepository.GetLatestEvents(6).ToList(),
                LatestNews = eventRepository.GetLatestNews(3).ToList(),
                 latestPhotos = photoRepository.GetCategoryImages(38)
            };
            //   ViewBag.FullUrl = Util.GetApplicationFullUrlWithoutLastSlash();

            return View(homeModel);
        }


    }
}
