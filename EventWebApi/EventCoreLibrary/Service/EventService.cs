using EventCoreLibrary.Data;
using EventCoreLibrary.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventCoreLibrary.Service
{
    public class EventService : IEventService
    {
        private IEventRepository _repo;
        public EventService()
        {
            _repo = new EventRepository();
        }
        public List<Exhibition> GetOrganizerExhibitions()
        {
            return _repo.Get();
        }

        public void AddOrganizer(Organizer org)
        {
            _repo.AddOrg(org);
        }
        public void AddExhibition(Exhibition exhibition)
        {
            _repo.AddExhibition(exhibition);
        }
        public List<Exhibition> GetOrgExhibition(string id)
        {
            return _repo.GetOrgExh(id);
        }

        public List<string> GetEventCountryByOidEid(string oid,string eid)
        {
            return _repo.GetCountryByOidEid(oid, eid);
        }
        public List<string> GetEventStateByOidEid(string oid,string eid)
        {
            return _repo.GetStateByOidEid(oid, eid);
        }
        public Exhibition GetExhByOidEid(string oid,string eid)
        {
            return _repo.GetExByOidEid(oid, eid);
        }
    }
}
