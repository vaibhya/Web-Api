using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using EventCoreLibrary.Service;
using EventCoreLibrary.Data;

namespace EventWebApi.Controllers
{
    [RoutePrefix("api/v1/organizer")]
    public class EventController : ApiController
    {
        private IEventService _service;
        public EventController(IEventService service)
        {
            _service = service;
        }
        //[Route("{organizerId}")]
        [Route("Exhibitions")]
        public IHttpActionResult GetExhibitions()
        {
            List<Exhibition> exhList = _service.GetOrganizerExhibitions();
            if (exhList == null)
            {
                return BadRequest("Some Error retrieving data");
            }
            return Json(exhList);
        }
        [Route("Post")]
        public IHttpActionResult PostOrganiner(Organizer org)
        {
            org.Oid = Guid.NewGuid().ToString();
            _service.AddOrganizer(org);
            return Ok(org.Oid);
        }
        [Route("Post/Exhibition")]
        public IHttpActionResult AddExhibition(Exhibition exhibition)
        {
            exhibition.Eid = Guid.NewGuid().ToString();

            
            return Ok(exhibition.Eid);
        }
        [Route("{organizerId}/Exhibitions")]
        public IHttpActionResult Get(string organizerId)
        {
            List<Exhibition> list = _service.GetOrgExhibition(organizerId);
            if (list == null)
            {
                return BadRequest("No exhibitions for this organizer");
            }
            return Ok(list);
        }
        [Route("{organizerId}/exhibitions/{exhibitionId}/country")]
        public IHttpActionResult GetCouByOidEid(string organizerId,string exhibitionId)
        {
            var list = _service.GetEventCountryByOidEid(organizerId, exhibitionId);
            if (list == null)
            {
                return BadRequest("No Country found for provided organizerId and Exhibition Id");
            }
            return Ok(list);
        }
        [Route("{organizerId}/exhibitions/{exhibitionId}/state")]
        public IHttpActionResult GetStateByOidEid(string organizerId, string exhibitionId)
        {
            var list = _service.GetEventStateByOidEid(organizerId, exhibitionId);
            if (list == null)
            {
                return BadRequest("No state found for provided organizerId and Exhibition Id");
            }
            return Ok(list);
        }
        [Route("{organizerId}/exhibitions/{id}")]
        public IHttpActionResult GetExhibitonByOidEid(string organizerId,string id)
        {
            var exhitition = _service.GetExhByOidEid(organizerId, id);
            if (exhitition == null)
            {
                return BadRequest("No exhibition Found!");
            }
            return Ok(exhitition);
        }

        
    }
}