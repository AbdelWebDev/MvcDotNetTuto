using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Tutoriel.Controllers
{
    public class ArticleController : Controller
    {
        // GET: Article
        [Route("lire/{id}/{title}")]
        public ActionResult Lire(int id,String title)
        {
            //String title = Request.Params["title"];
            ViewBag.ArticleId = id;
            if(!string.IsNullOrEmpty(title)) ViewBag.ArticleTitle = title.Replace('-',' ');
            return View();
        }

        //[Route("all"),Route("tous")]
        [Route("{Type:regex(all|tous)}")]
        public ActionResult allArticles()
        {
            return View();
        }
    }
}