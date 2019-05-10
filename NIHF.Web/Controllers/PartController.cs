using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NIHF.Web.Models;

namespace NIHF.Web.Controllers
{
    public class PartController : Controller
    {
        DataAccessLayer dal = new DataAccessLayer();

        [HttpGet]
        [Route("api/Part/Index")]
        public IEnumerable<Part> Index()
        {
            return dal.GetAllParts();
        }

        [HttpPost]
        [Route("api/Part/Create")]
        public int Create(Part part)
        {
            return dal.AddPart(part);
        }

        [HttpDelete]
        [Route("api/Part/Delete/{id}")]
        public int Delete(int id)
        {
            return dal.DeletePart(id);
        }

        [HttpGet]
        [Route("api/Part/GetManufacturer")]
        public IEnumerable<Manufacturer> GetManufacturer()
        {
            return dal.GetAllManufacturers();
        }

    }
}