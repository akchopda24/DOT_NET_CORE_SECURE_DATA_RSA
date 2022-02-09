using Microsoft.AspNetCore.Mvc;
using System;

namespace DOT_NET_CORE_SECURE_DATA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatusController : ControllerBase
    {
        // GET: api/Status
        [HttpGet]
        public string Get() => $"Started - {DateTime.Now}";
    }
}
