using System.Collections.Generic;

namespace UniversityApp.Data.Interfaces
{
    public interface IAnnouncementData
    {
        IEnumerable<Announcement> GetAllAnnouncements();
        Announcement AddAnnouncement(Announcement announcement);
        int Commit();
        Announcement RemoveAnnouncement(string topicId);
        Announcement GetSpecificAnnouncement(string topicId);
    }
}
