using System;
using System.Collections.Generic;
using System.Linq;
using UniversityApp.Data.Interfaces;

namespace UniversityApp.Data.UserData
{
    public class SqlAnnouncementData : IAnnouncementData
    {
        public ApplicationDbContext db { get; }
        public SqlAnnouncementData(ApplicationDbContext db)
        {
            this.db = db;
        }

        public Announcement AddAnnouncement(Announcement announcement)
        {
            db.DbAnnouncement.Add(announcement);
            return announcement;
        }

        public IEnumerable<Announcement> GetAllAnnouncements()
        {
            var query = from r in db.DbAnnouncement.ToList()
                        orderby r.Date
                        select r;

            return query;
        }

        public int Commit()
            => db.SaveChanges();

        public Announcement GetSpecificAnnouncement(string title)
            => db.DbAnnouncement.Where(x => x.Title == title).FirstOrDefault();

        public Announcement RemoveAnnouncement(string topicId)
        {
            var topic = GetSpecificAnnouncement(topicId);

            if (topic != null)
                db.DbAnnouncement.Remove(topic);

            return topic;
        }
    }
}
