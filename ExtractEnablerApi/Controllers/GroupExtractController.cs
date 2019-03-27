using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExtractEnablerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroupExtractController : ControllerBase
    {
        public IActionResult GetExtract()
        {

            return Ok();
        }

    }
}