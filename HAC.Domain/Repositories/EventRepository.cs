﻿using System;
using System.Data;
using System.Linq;

namespace HAC.Domain.Repositories
{

    public class EventRepository
    {
        private HAC2CeEntities context = new HAC2CeEntities();

        public void Save(Event _event)
        {
            if (_event.ID == 0)
            {
                context.Events.Add(_event);
            }
            else
            {
                context.Entry(_event).State = EntityState.Modified;
            }
            context.SaveChanges();
        }

        public IQueryable<Event> GetLatestEvents(int count)
        {
            return context.Events.Where(e => e.Date >= DateTime.Now).OrderBy(e => e.Date).Take(count);
        }

        public IQueryable<Event> GetAllForthcomingEvents()
        {
            return context.Events.Where(e => e.Date >= DateTime.Now).OrderBy(e => e.Date);
        }

        public IQueryable<Event> GetEvents(DateTime fromDate, DateTime toDate)
        {
            return context.Events.Where(e => e.Date >= fromDate && e.Date <= toDate).OrderBy(e => e.Date);
        }

        public IQueryable<Event> GetLatestNews(int count)
        {
            return context.Events.Where(e => e.Date <= DateTime.Now && e.news1 != "").OrderByDescending(e => e.Date).Take(count);
        }

        public Event GetNewsEvent(int id)
        {
            return context.Events.SingleOrDefault(e => e.ID == id);
        }

    }
}
