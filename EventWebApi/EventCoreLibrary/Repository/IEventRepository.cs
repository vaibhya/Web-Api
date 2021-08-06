using EventCoreLibrary.Data;
using System.Collections.Generic;

namespace EventCoreLibrary.Repository
{
    public interface IEventRepository
    {
        List<Exhibition> Get();
        void AddOrg(Organizer org);

        void AddExhibition(Exhibition exhibition);

        List<Exhibition> GetOrgExh(string id);
        List<string> GetCountryByOidEid(string oid, string eid);

        List<string> GetStateByOidEid(string oid, string eid);
        Exhibition GetExByOidEid(string oid, string eid);
    }
}