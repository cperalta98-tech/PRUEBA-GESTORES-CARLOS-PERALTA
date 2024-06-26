using gestores.Dto;
using gestores.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace gestores.Controllers
{
    public class GestorController : Controller
    {
        private readonly BDGestoresContext _bDGestoresContext;
        public GestorController()
        {
            _bDGestoresContext = new BDGestoresContext();
        }
        // GET: Gestor
        public ActionResult Index()
        {         
            return View();
        }
        public JsonResult getGestores()
        {
            List<GestorEntity> listgestor = new List<GestorEntity>();
            listgestor = _bDGestoresContext.TblGestore.Where(x => x.Activo == true)
                                                        .Select(x => new GestorEntity
                                                        {
                                                            IdGestor = x.IdGestor,
                                                            Gestor = x.Gestor,
                                                            Activo = x.Activo
                                                        }).ToList();
            foreach (var item in listgestor)
            {
                List<GestorSaldoDetalleEntity> listaDetalleSaldoGestor = _bDGestoresContext.TblGestorSaldoDetalle.Where(x => x.IdGestor == item.IdGestor)
                                                                                                              .Select(x => new GestorSaldoDetalleEntity
                                                                                                              {
                                                                                                                  IdGestor = x.IdGestor,
                                                                                                                  IdSaldo = x.IdSaldo,
                                                                                                                  Monto = (decimal)x.IdSaldoNavigation.Monto,
                                                                                                                  Activo = x.Activo
                                                                                                              }).ToList();
                foreach (var item2 in listaDetalleSaldoGestor)
                {
                    GestorSaldoDetalleEntity objGestor = new GestorSaldoDetalleEntity()
                    {
                        IdGestorSaldoDetalle = item2.IdGestorSaldoDetalle,
                        IdGestor = item2.IdGestor,
                        IdSaldo = item2.IdSaldo,
                        Monto = item2.Monto,
                        Activo = item2.Activo
                    };
                    item.gestorSaldoDetalleEntities.Add(objGestor);
                }


            }
            return Json(new { data = listgestor }, JsonRequestBehavior.AllowGet);
        }

        // POST: Gestor/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Gestor/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Gestor/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Gestor/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Gestor/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
