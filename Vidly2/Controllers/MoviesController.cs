using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Vidly2.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Index(int? pageIndex, string sortby)
        {

            if(!pageIndex.HasValue) pageIndex = 1;

            if(String.IsNullOrWhiteSpace(sortby)) sortby = "Name";

            return Content(String.Format("pageIndex={0}&sortby={1}", pageIndex, sortby));
        }

        public ActionResult Edit(int id)
        {
            return Content(""+id);
        }
    }
}