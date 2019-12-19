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
using APIPerroflautasFinal.Models;

namespace APIPerroflautasFinal.Controllers
{
    public class PerroflautasController : ApiController
    {
        private Contextum db = new Contextum();

        // GET: api/Perroflautas
        public IQueryable<Perroflautas> GetPerroflautas()
        {
            return db.Perroflautas;
        }

        // GET: api/Perroflautas/5
        [ResponseType(typeof(Perroflautas))]
        public IHttpActionResult GetPerroflautas(int id)
        {
            Perroflautas perroflautas = db.Perroflautas.Find(id);
            if (perroflautas == null)
            {
                return NotFound();
            }

            return Ok(perroflautas);
        }

        // PUT: api/Perroflautas/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutPerroflautas(int id, Perroflautas perroflautas)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != perroflautas.Id)
            {
                return BadRequest();
            }

            db.Entry(perroflautas).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PerroflautasExists(id))
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

        // POST: api/Perroflautas
        [ResponseType(typeof(Perroflautas))]
        public IHttpActionResult PostPerroflautas(Perroflautas perroflautas)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Perroflautas.Add(perroflautas);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (PerroflautasExists(perroflautas.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = perroflautas.Id }, perroflautas);
        }

        // DELETE: api/Perroflautas/5
        [ResponseType(typeof(Perroflautas))]
        public IHttpActionResult DeletePerroflautas(int id)
        {
            Perroflautas perroflautas = db.Perroflautas.Find(id);
            if (perroflautas == null)
            {
                return NotFound();
            }

            db.Perroflautas.Remove(perroflautas);
            db.SaveChanges();

            return Ok(perroflautas);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PerroflautasExists(int id)
        {
            return db.Perroflautas.Count(e => e.Id == id) > 0;
        }
    }
}