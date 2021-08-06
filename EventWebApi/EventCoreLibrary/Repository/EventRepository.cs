using EventCoreLibrary.Data;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventCoreLibrary.Repository
{
    public class EventRepository : DbContext, IEventRepository
    {
        public DbSet<Exhibition> Exhibitions { get; set; }
        public DbSet<Organizer> Organizer { get; set; }
        public EventRepository()
        {
            Database.SetInitializer<EventRepository>(new CreateDatabaseIfNotExists<EventRepository>());

        }
        public List<Exhibition> Get()
        {
            return Exhibitions.ToList();
            //return exbList;
        }
        public void AddOrg(Organizer org)
        {
            Organizer.Add(org);
            this.SaveChanges();
        }
        public void AddExhibition(Exhibition exhibition)
        {
            Exhibitions.Add(exhibition);
            this.SaveChanges();
        }
        public List<Exhibition> GetOrgExh(string id)
        {
            var list = Exhibitions.Where(o => o.Oid.Oid == id).ToList();
            return list;
        }
        public List<string> GetCountryByOidEid(string oid,string eid)
        {
            var country = Exhibitions
                            .Where(e => e.Eid == eid && e.Oid.Oid == oid)
                            //.Where(e => e.Oid.Oid == oid)
                            .Select(e => e.Country);
            var result = country.ToList();
            return result;
        }
        public List<string> GetStateByOidEid(string oid,string eid)
        {
            var state = Exhibitions
                            .Where(e => e.Eid == eid && e.Oid.Oid == oid)
                            //.Where(e => e.Oid.Oid == oid)
                            .Select(e => e.State);
            var result = state.ToList();
            return result;
        }
        public Exhibition GetExByOidEid(string oid,string eid)
        {
            var exhibition = Exhibitions
                                .Where(e => e.Eid == eid && e.Oid.Oid == oid).First();
            
            return exhibition;
        }
    }
}
