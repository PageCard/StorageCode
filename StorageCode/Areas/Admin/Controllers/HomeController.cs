using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StorageCode.Models;
using Newtonsoft.Json;
using System.Data;

namespace StorageCode.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {

         StorageCode.Models.StorageCode db = new StorageCode.Models.StorageCode();
        // GET: Admin/Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Table(int page,int limit)
        {

            var data = db.S_Menu.OrderBy(t => t.M_id).Skip(limit * (page - 1))
                           .Take(limit).ToList ();
            ;

            return Json(new { code = 0, msg = "", count = db.S_Menu.Count(), data = data }, JsonRequestBehavior.AllowGet);
        }
  /// <summary>
  /// 生成菜单树（系统管理员生成）
  /// </summary>
  /// <returns></returns>
        public ActionResult Tree()
        {
            List<List<root>> rootIn = new List<List<root>>();
            DataTable nn = new DataTable();
            var dbk = db.S_Menu.ToList();
            var n = dbk.Where(t => t.M_ParentId == null).ToList();
            List<root> root = new List<root>();
            List<list> ListInfo = new List<list>();
            foreach (var infoN in n)
            {
                root model = new root();
                model.title = infoN.M_Name;
              
                model.value = infoN.M_id;
                model.data = new List<list>();
                var k = dbk.Where(t => t.M_ParentId == infoN.M_id).ToList();
                foreach (var nnn in k)
                {
                    list modellist = new list();
                    data mod = new data();
                    mod.item = "";
                    modellist.title = nnn.M_Name;
                    modellist.href = nnn.M_url;
                
                    modellist.value = nnn.M_id;
                    modellist.data = new List<data>();
                    model.data.Add(modellist);
                }
                root.Add(model);
            }
            rootIn.Add(root);
            return Content(JsonConvert.SerializeObject(rootIn), "application/json; charset=UTF-8");

        }
       
        public class root
        {
            public string title { get; set; }
            public string value { get; set; }
            public List<list> data { get; set; }
        }
        public class list
        {

            public string title { get; set; }
            public string href { get; set; }
            public string value { get; set; }
            public List<data> data { get; set; }
          
        }
        public class data
        {
            public string item { get; set; }
        }

    }
}