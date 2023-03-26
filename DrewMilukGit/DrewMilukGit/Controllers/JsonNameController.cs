using Microsoft.AspNetCore.Mvc;
using System;
using System.Web.Http;
using System.Web.Mvc;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace DrewMilukGit.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JsonNameController : Controller
    {
        // GET: JsonName
        // Drew Miluk
        public ActionResult<object> Get()
        {
            return Ok(new { data = "Drew Miluk" });
        }

        private ActionResult<object> Ok(object value)
        {
            throw new NotImplementedException();
        }

    }
}