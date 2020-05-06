using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace NancyApi.Controller
{
    public class ArticleController : ControllerBase
    {
        public ArticleController()
        {
            
        }

        public IActionResult Get()
        {
            return Ok("ping");
        }

        public IActionResult GetList([FromRoute] string section)
        {
            return Ok();
        }

        public IActionResult GetFirst([FromRoute] string section)
        {
            return Ok();
        }

        public IActionResult GetFilteredByUpdatedDate([FromRoute] string section, [FromRoute] DateTime updatedDate)
        {
            return Ok();
        }

        public IActionResult GetGroup([FromRoute] string section)
        {
            return Ok();
        }
    }
}
