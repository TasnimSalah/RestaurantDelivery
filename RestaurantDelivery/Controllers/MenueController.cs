using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantDelivery.Controllers
{
    public class MenueController : Controller
    {
        // GET: MenueController
        public ActionResult Index()
        {
            return View();
        }

        // GET: MenueController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MenueController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MenueController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MenueController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MenueController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MenueController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MenueController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
