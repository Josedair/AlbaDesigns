using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebStore.Models;

namespace WebStore.Controllers
{
    public class Image_uploadController : Controller
    {
        // GET: Image_upload
        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public  ActionResult Add(Image_upload  imageModel)
        {
            string fileName = Path.GetFileNameWithoutExtension(imageModel.ImageFile.FileName);
            string extension = Path.GetExtension(imageModel.ImageFile.FileName);
            fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
            imageModel.ImagePath = "~/ImageUploads/" + fileName;
            fileName = Path.Combine(Server.MapPath("~/ImageUploads"));
            imageModel.ImageFile.SaveAs(fileName);
            //using (DbModel db = new DbModel())
            //{
            //    db.Images.Add(imageModel);
            //    db.SaveChanges();
            //}
            return View();
        }
    }
}