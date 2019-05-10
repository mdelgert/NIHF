using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NIHF.Web.Models;

namespace NIHF.Web.Controllers
{
    public class ManufacturerController : Controller
    {
        DataAccessLayer dal = new DataAccessLayer();

        //CREATE
        [HttpPost]
        [Route("api/Manufacturer/Create")]
        public int Create(Manufacturer manufacturer)
        {
            return dal.CreateManufacturer(manufacturer);
        }

        //READ ALL
        [HttpGet]
        [Route("api/Manufacturer/Index")]
        public IEnumerable<Manufacturer> Index()
        {
            return dal.GetAllManufacturers();
        }

        ////UPDATE

        ////DELETE
        [HttpDelete]
        [Route("api/Manufacturer/Delete/{id}")]
        public int Delete(int id)
        {
            return dal.DeleteManufacturer(id);
        }

    }
}