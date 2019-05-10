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

        #region PARTS

        //CREATE
        public int CreatePart(Part part)
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

        //READ
        public IEnumerable<Part> ReadAllParts()
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

        //UPDATE

        //DELETE
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
        #endregion

        #region MANUFACTURERS
        //CREATE
        public int CreateManufacturer(Manufacturer manufacturer)
        {
            try
            {
                db.Manufacturer.Add(manufacturer);
                db.SaveChanges();
                return 1;
            }
            catch
            {
                throw;
            }
        }

        //READ ALL 
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

        //UPDATE

        //DELETE
        public int DeleteManufacturer(int id)
        {
            try
            {
                Manufacturer manufacturer = db.Manufacturer.Find(id);
                db.Manufacturer.Remove(manufacturer);
                db.SaveChanges();
                return 1;
            }
            catch
            {
                throw;
            }
        }
        #endregion
    }
}
