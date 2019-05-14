using System.Collections.Generic;
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

        //READ
        [HttpGet]
        [Route("api/Part/Read/{id}")]
        public Part Read(int id)
        {
            return dal.ReadPart(id);
        }

        //READ ALL
        [HttpGet]
        [Route("api/Part/Index")]
        public IEnumerable<Part> Index()
        {
            return dal.ReadAllParts();
        }

        //UPDATE
        [HttpPut]
        [Route("api/Part/Update")]
        public int Edit(Part part)
        {
            return dal.UpdatePart(part);
        }

        //DELETE
        [HttpDelete]
        [Route("api/Part/Delete/{id}")]
        public int Delete(int id)
        {
            return dal.DeletePart(id);
        }
    }
}