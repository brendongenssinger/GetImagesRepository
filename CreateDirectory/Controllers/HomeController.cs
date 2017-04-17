using System.Web.Mvc;
using System.IO;
using System;
using CreateDirectory.Models;
using System.Collections.Generic;
namespace CreateDirectory.Controllers

{
    public class HomeController : Controller
    {
        int id = 0;
        public ActionResult Index()
        {
            return View();
        }
        public HomeController()
        {
            getImagens();
        }

        [HttpPost]
        public ActionResult Index(Clientes cliente)
        {
            try
            {
                foreach (string filename in Request.Files)
                {
                    id++;
                    var fileName = Request.Files[filename];
                    var path = Server.MapPath("~/App_Data/Imagens/" + id);
                    var pathImage = Path.Combine(Server.MapPath("/App_Data/Imagens/" + id), fileName.FileName);

                    if (!Directory.Exists("~/App_Data/Imagens/" + id))
                    {
                        Directory.CreateDirectory(path);
                        fileName.SaveAs(pathImage);
                    }
                    else
                    {
                        fileName.SaveAs(path);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }          
         

            return View();

        }

        public ActionResult getImagens()
        {
            Clientes ci = new Clientes();
            DirectoryInfo diretorio = new DirectoryInfo("~/App_Data/Imagens/1");            
            FileInfo[] arquivos = diretorio.GetFiles();
            foreach (var item in arquivos)
            {
                ci.NameImagens.Add(item.FullName);
            }
            return Index();
        }
    }
}