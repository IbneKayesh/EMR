using EMR.DataAccess;
using EMR.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMR.Controllers
{
    public class PrescriptionsController : Controller
    {
        private readonly emrDbContext db;
        public PrescriptionsController(emrDbContext _db)
        {
            db = _db;
        }
        public IActionResult Index()
        {
            PRESCRIPTIONS obj = new PRESCRIPTIONS();
            return View(obj);
        }
        [HttpPost]
        public IActionResult Index(PRESCRIPTIONS obj)
        {
            obj.PRESCRIBE_DATE = DateTime.Now;

            using var trn = db.Database.BeginTransaction();
            try
            {
                db.PRESCRIPTIONS.Add(obj);
                db.SaveChanges();
                db.PRESCRIPTIONS_DRUGS.AddRange(obj.PRESCRIPTIONS_DRUGS);
                db.SaveChanges();
                db.PRESCRIPTIONS_INVES.AddRange(obj.PRESCRIPTIONS_INVES);
                db.SaveChanges();
                trn.Commit();
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                trn.Rollback();
            }

            return View(obj);
        }
    }
}
