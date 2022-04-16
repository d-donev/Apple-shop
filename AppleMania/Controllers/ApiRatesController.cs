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
    public class ApiRatesController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: api/ApiRates
        public IQueryable<Rate> GetRates()
        {
            return db.Rates;
        }

        // GET: api/ApiRates/5
        [ResponseType(typeof(Rate))]
        public IHttpActionResult GetRate(int id)
        {
            Rate rate = db.Rates.Find(id);
            if (rate == null)
            {
                return NotFound();
            }

            return Ok(rate);
        }

        // PUT: api/ApiRates/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutRate(int id, Rate rate)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != rate.Id)
            {
                return BadRequest();
            }

            db.Entry(rate).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RateExists(id))
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

        // POST: api/ApiRates
        [ResponseType(typeof(Rate))]
        public IHttpActionResult PostRate(Rate rate)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Rates.Add(rate);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = rate.Id }, rate);
        }

        // DELETE: api/ApiRates/5
        [ResponseType(typeof(Rate))]
        public IHttpActionResult DeleteRate(int id)
        {
            Rate rate = db.Rates.Find(id);
            if (rate == null)
            {
                return NotFound();
            }

            db.Rates.Remove(rate);
            db.SaveChanges();

            return Ok(rate);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool RateExists(int id)
        {
            return db.Rates.Count(e => e.Id == id) > 0;
        }
    }
}