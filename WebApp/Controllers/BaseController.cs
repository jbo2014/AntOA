using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ant;
using WebApp.Utility;

namespace WebApp.Controllers
{
    public class BaseController : Controller
    {
        public AntApi Ant { get { return new AntApi(); } }
    }
}
