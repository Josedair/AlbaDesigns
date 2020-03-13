using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;
using WebStore.Models;
namespace WebStore.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        DAL.Db dbLayer = new DAL.Db();
        public ActionResult Test()
        {
            return View();
        }

        public JsonResult Get_data()
        {
            DataSet ds = dbLayer.Show_data();
            List<product> listreg = new List<product>();
            foreach (DataRow dr in ds.Tables[3].Rows)
            {
                listreg.Add(new product
                {
                    ProductID = Convert.ToInt32(dr["ProductID"]),
                    ProductName = dr["ProductName"].ToString(),
                });
            }
            return Json(listreg, JsonRequestBehavior.AllowGet);
        }




    }
}