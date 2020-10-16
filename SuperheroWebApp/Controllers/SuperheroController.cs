using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SuperheroWebApp.Data;
using SuperheroWebApp.Models;

namespace SuperheroWebApp.Controllers
{
    public class SuperheroController : Controller
    {
        private readonly ApplicationDbContext db;
        public SuperheroController(ApplicationDbContext _db)
        {
            db = _db;
        }
        // GET: SuperheroController
        public ActionResult Index()
        {
            var superherosInDatabase = db.Superheros;
            return View(superherosInDatabase);
        }

        // GET: SuperheroController/Details/5
        public ActionResult Details(int id)
        {
            var heroToView = db.Superheros.Where(c => c.Id == id).SingleOrDefault();
            return View(heroToView);
        }

        // GET: SuperheroController/Create
        public ActionResult Create()
        {
            Superhero superhero = new Superhero();
            return View(superhero);
        }

        // POST: SuperheroController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Superhero superhero)
        {
            try
            {
                db.Superheros.Add(superhero);
                db.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch(Exception e)
            {
                return View();
            }
        }

        // GET: SuperheroController/Edit/5
        public ActionResult Edit(int id)
        {
            var superheroToEdit = db.Superheros.Where(c => c.Id == id).SingleOrDefault();
            return View(superheroToEdit);
        }

        // POST: SuperheroController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Superhero superhero)
        {
            try
            {

                db.Superheros.Update(superhero); 
                db.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SuperheroController/Delete/5
        public ActionResult Delete(int id)
        {
            var herotoDelete = db.Superheros.Where(c => c.Id == id).SingleOrDefault();
            return View(herotoDelete);
        }

        // POST: SuperheroController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Superhero superhero)
        {
            try
            {
                //var herotoDelete = db.Superheros.Where(c => c.Id == id).SingleOrDefault();
                db.Superheros.Remove(superhero);
                db.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch(Exception e)
            {
                return View();
            }
        }


       
    }
}
