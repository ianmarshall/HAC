using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using HAC.Domain;
using HAC.Domain.Repositories;
using HAC.Web.Models;

namespace HAC.Web.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            EventRepository eventRepository = new EventRepository();
         //   PhotoRepository photoRepository = new PhotoRepository();
            AnnouncementRepository announcementRepository = new AnnouncementRepository();

            var homeModel = new HomeModel()
            {
               LatestAnnouncements = announcementRepository.GetLatestAnnouncements(4).ToList(),
                ActiveAnnouncementsCount = announcementRepository.GetActiveAnnouncements().Count(),
                LatestEvents = eventRepository.GetLatestEvents(6).ToList(),
                LatestNews = new List<Event>()
              //  latestPhotos = photoRepository.GetCategoryImages(38)
            };
         //   ViewBag.FullUrl = Util.GetApplicationFullUrlWithoutLastSlash();

            return View(homeModel);
        }

       
    }
}
