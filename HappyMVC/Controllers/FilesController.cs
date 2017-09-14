using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace HappyMVC.Controllers
{
    public class FilesController : Controller
    {
        // GET: Files
        public ActionResult Index()
        {
            string[] files = Directory.GetFiles(Server.MapPath("~/TextFiles"));
            string[] fileNames = new string[files.Length];
            int i = 0;
            foreach (string file in files)
            {
                fileNames[i++] = Path.GetFileName(file);
            }
            ViewData["files"] = fileNames;
            return View(fileNames);
        }

        public ActionResult Display(String id)
        {
            string[] filePath = System.IO.File.ReadAllLines(Server.MapPath("~/TextFiles/" + id + ".txt"));
            return View(filePath);
        }
    }
}