using EventCoreLibrary.Data;
using System.Collections.Generic;

namespace EventCoreLibrary.Service
{
    public interface IEventService
    {
        List<Exhibition> GetOrganizerExhibitions();
        void AddOrganizer(Organizer org);

        void AddExhibition(Exhibition exhibition);

        //List<Exhibition> GetOrgExhibition();
        List<Exhibition> GetOrgExhibition(string id);
        List<string> GetEventCountryByOidEid(string oid, string eid);

        List<string> GetEventStateByOidEid(string oid, string eid);

        Exhibition GetExhByOidEid(string oid, string eid);
    }
}