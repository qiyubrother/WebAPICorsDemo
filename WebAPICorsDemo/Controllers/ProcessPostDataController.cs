using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPICorsDemo.Controllers
{
    [EnableCors("AllowCors"), Route("api/[controller]")]
    [ApiController]
    public class ProcessPostDataController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "ProcessPostData-1", "ProcessPostData-2" };
        }

        // POST api/values
        [HttpPost]
        [EnableCors("any")]
        public void Post([FromBody] CPostData value)
        {

        }
    }
}