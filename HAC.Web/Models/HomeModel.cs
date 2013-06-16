using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HAC.Web.Models
{
    public class HomeModel
    {

        public List<Domain.Announcement> LatestAnnouncements { get; set; }
        public int ActiveAnnouncementsCount { get; set; }
        public List<Domain.Event> LatestEvents { get; set; }
        public List<Domain.Event> LatestNews { get; set; }
        //public Member Member { get; set; }
        //public List<pic_images> latestPhotos { get; set; }



    }
}