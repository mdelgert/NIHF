using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NIHF.Web.Models
{
    public class DataAccessLayer
    {
        Context db = new Context();

        public IEnumerable<Part> GetAllParts()
        {
            try
            {
                return db.Part.ToList();
            }
            catch
            {
                throw;
            }
        }

        //To Add new part record   
        public int AddPart(Part part)
        {
            try
            {
                db.Part.Add(part);
                db.SaveChanges();
                return 1;
            }
            catch
            {
                throw;
            }
        }

        //To Delete the record of a particular part 
        public int DeletePart(int id)
        {
            try
            {
                Part emp = db.Part.Find(id);
                db.Part.Remove(emp);
                db.SaveChanges();
                return 1;
            }
            catch
            {
                throw;
            }
        }

        public IEnumerable<Manufacturer> GetAllManufacturers()
        {
            try
            {
                return db.Manufacturer.ToList();
            }
            catch
            {
                throw;
            }
        }
    }
}
