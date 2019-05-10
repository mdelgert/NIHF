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

        //CREATE
        [HttpPost]
        [Route("api/Part/Create")]
        public int Create(Part part)
        {
            return dal.CreatePart(part);
        }

        //READ ALL
        [HttpGet]
        [Route("api/Part/Index")]
        public IEnumerable<Part> Index()
        {
            return dal.ReadAllParts();
        }

        //UPDATE

        //DELETE
        [HttpDelete]
        [Route("api/Part/Delete/{id}")]
        public int Delete(int id)
        {
            return dal.DeletePart(id);
        }
    }
}