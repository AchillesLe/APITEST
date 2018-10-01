using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using API_V2.Models;
namespace API_V2.Controllers
{
    [RoutePrefix("api/category")]
    public class CategoryController : ApiController
    {
        private ShopDBTestModel _context = new ShopDBTestModel();
        [HttpGet, Route("getall")]
        public List<category> getALL()
        {
            return _context.categories.ToList();
        }
    }
}
