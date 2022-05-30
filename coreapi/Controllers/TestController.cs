using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace coreapi.Controllers
{
    [ApiController]
    [Route("api/test")]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            var list = new List<string>();
            var cookies = Request.Cookies;
            foreach (var cookie in cookies)
            {
                list.Add($"{cookie.Key}:{cookie.Value}");
            }
            list.Add("foo");
            return list;
        }
    }
}