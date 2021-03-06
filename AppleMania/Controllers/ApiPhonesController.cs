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
    public class ApiPhonesController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: api/ApiPhones
        public IQueryable<Phone> GetPhones()
        {
            return db.Phones;
        }

        // GET: api/ApiPhones/5
        [ResponseType(typeof(Phone))]
        public IHttpActionResult GetPhone(int id)
        {
            Phone phone = db.Phones.Find(id);
            if (phone == null)
            {
                return NotFound();
            }

            return Ok(phone);
        }

        // PUT: api/ApiPhones/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutPhone(int id, Phone phone)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != phone.Id)
            {
                return BadRequest();
            }

            db.Entry(phone).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PhoneExists(id))
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

        // POST: api/ApiPhones
        [ResponseType(typeof(Phone))]
        public IHttpActionResult PostPhone(Phone phone)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Phones.Add(phone);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = phone.Id }, phone);
        }

        // DELETE: api/ApiPhones/5
        [ResponseType(typeof(Phone))]
        public IHttpActionResult DeletePhone(int id)
        {
            Phone phone = db.Phones.Find(id);
            if (phone == null)
            {
                return NotFound();
            }

            db.Phones.Remove(phone);
            db.SaveChanges();

            return Ok(phone);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PhoneExists(int id)
        {
            return db.Phones.Count(e => e.Id == id) > 0;
        }
    }
}