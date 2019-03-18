using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using whereareyou.Models;

namespace whereareyou.Controllers
{
    [Route("api")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        [HttpPost]
        [Route("auth")]
        public ActionResult<string> Auth([FromBody] AuthRequest authRequest)
        {
            return Guid.NewGuid().ToString();
        }
    }
}