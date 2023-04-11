using MVC_DropDownList.Models;
using MVC_DropDownList.Models.Viewmodel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace MVC_DropDownList.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            SelectList sehirler = new SelectList(Sehir.SehirGetir(), "SehirId", "SehirAdi");
            SelectList ulkeler = new SelectList(Ulke.UlkeGetir(), "UlkeId", "UlkeAdi");

            ViewBag.sehirler = sehirler;
            ViewBag.ulkeler = ulkeler;
            return View();
        }
        [HttpPost]
        public ActionResult Index(int SehirBilgisi, int UlkeBilgisi)
        {
            ViewBag.UlkeId=UlkeBilgisi;
            ViewBag.SehirId=SehirBilgisi;

            SelectList sehirler = new SelectList(Sehir.SehirGetir(), "SehirId", "SehirAdi");
            SelectList ulkeler = new SelectList(Ulke.UlkeGetir(), "UlkeId", "UlkeAdi");

            ViewBag.sehirler = sehirler;
            ViewBag.ulkeler = ulkeler;
            return View();
        }
        public ActionResult Index2()
        {
            SelectList sehirler = new SelectList(Sehir.SehirGetir(), "SehirId", "SehirAdi");
            SelectList ulkeler = new SelectList(Ulke.UlkeGetir(), "UlkeId", "UlkeAdi");

            ViewBag.sehirler = sehirler;
            ViewBag.ulkeler = ulkeler;

            IndexModel model=new IndexModel() 
            {
                SecilenSehirId=-1,
                SecilenUlkeId=-1,
                UlkeListesi=new SelectList(Ulke.UlkeGetir(),"UlkeId","UlkeAdi"),
                SehirListesi=new SelectList(Sehir.SehirGetir(),"SehirId","SehirAdi"),

            };
            return View(model);
            
        }
        [HttpPost]
        public ActionResult Index2(IndexModel model)
        {
            model.UlkeListesi = new SelectList(Ulke.UlkeGetir(), "UlkeId", "UlkeAdi");
            model.SehirListesi = new SelectList(Sehir.SehirGetir(), "SehirId", "SehirAdi");

            ViewBag.SecilenUlkeId = model.SecilenUlkeId;
            ViewBag.SecilenSehirId=model.SecilenSehirId;
            return View(model);
        }
        public JsonResult SehirGetir(int id)
        {
            List<Sehir>liste= Sehir.SehirGetir().Where(x=>x.UlkeId==id).ToList();
            return Json(liste,JsonRequestBehavior.AllowGet);//bu sonucu geri döndürebilirsin diye izin veriyorum
        }
    }
}