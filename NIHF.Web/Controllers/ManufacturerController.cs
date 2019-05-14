using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using NIHF.Web.Models;

namespace NIHF.Web.Controllers
{
    public class ManufacturerController : Controller
    {
        DataAccessLayer dal = new DataAccessLayer();

        //CREATE

        //READ ALL
        [HttpGet]
        [Route("api/Manufacturer/Index")]
        public IEnumerable<Manufacturer> Index()
        {
            return dal.GetAllManufacturers();
        }

        ////UPDATE

        ////DELETE

    }
}