using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LearnASP.Models;

namespace LearnASP.Controllers
{
    public class NhanVienController : Controller
    {
        // GET: NhanVien
        public ActionResult Index()
        {
            using(qlnvEntities qlnv = new qlnvEntities())
            {
                return View(qlnv.NhanVien01.ToList());
            }
            
        }

        // GET: NhanVien/Details/5
        public ActionResult Details(int id)
        {
            using (qlnvEntities qlnv = new qlnvEntities())
            {
                return View(qlnv.NhanVien01.Where(x => x.id == id).FirstOrDefault());
            }
        }

        // GET: NhanVien/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NhanVien/Create
        [HttpPost]
        public ActionResult Create(NhanVien01 nhanVien)
        {
            try
            {
                // TODO: Add insert logic here
                using (qlnvEntities qlnv = new qlnvEntities())
                {
                    qlnv.NhanVien01.Add(nhanVien);
                    qlnv.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: NhanVien/Edit/5
        public ActionResult Edit(int id)
        {
            using (qlnvEntities qlnv = new qlnvEntities())
            {
                return View(qlnv.NhanVien01.Where(x => x.id == id).FirstOrDefault());
            }
        }

        // POST: NhanVien/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, NhanVien01 nhanVien)
        {
            try
            {
                // TODO: Add update logic here
                using(qlnvEntities qlnv = new qlnvEntities())
                {
                    qlnv.Entry(nhanVien).State = System.Data.EntityState.Modified;
                    qlnv.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: NhanVien/Delete/5
        public ActionResult Delete(int id)
        {
            using (qlnvEntities qlnv = new qlnvEntities())
            {
                return View(qlnv.NhanVien01.Where(x => x.id == id).FirstOrDefault());
            }
        }

        // POST: NhanVien/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                using (qlnvEntities qlnv = new qlnvEntities())
                {
                    NhanVien01 nhanVien = qlnv.NhanVien01.Where(x => x.id == id).FirstOrDefault();
                    qlnv.NhanVien01.Remove(nhanVien);
                    qlnv.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
