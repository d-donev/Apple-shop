using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using AppleMania.Models;

namespace AppleMania.Controllers
{
    [Authorize]
    public class ApiPadsController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: api/ApiPads
        public IQueryable<Pad> GetPads()
        {
            return db.Pads;
        }

        // GET: api/ApiPads/5
        [ResponseType(typeof(Pad))]
        public IHttpActionResult GetPad(int id)
        {
            Pad pad = db.Pads.Find(id);
            if (pad == null)
            {
                return NotFound();
            }

            return Ok(pad);
        }

        // PUT: api/ApiPads/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutPad(int id, Pad pad)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != pad.Id)
            {
                return BadRequest();
            }

            db.Entry(pad).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PadExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/ApiPads
        [ResponseType(typeof(Pad))]
        public IHttpActionResult PostPad(Pad pad)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Pads.Add(pad);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = pad.Id }, pad);
        }

        // DELETE: api/ApiPads/5
        [ResponseType(typeof(Pad))]
        public IHttpActionResult DeletePad(int id)
        {
            Pad pad = db.Pads.Find(id);
            if (pad == null)
            {
                return NotFound();
            }

            db.Pads.Remove(pad);
            db.SaveChanges();

            return Ok(pad);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PadExists(int id)
        {
            return db.Pads.Count(e => e.Id == id) > 0;
        }
    }
}