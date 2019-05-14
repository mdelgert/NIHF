using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;

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
        public Part ReadPart(int id)
        {
            try
            {
                Part part = db.Part.Find(id);
                return part;
            }
            catch
            {
                throw;
            }
        }

        //READ ALL
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
        public int UpdatePart(Part part)
        {
            try
            {
                db.Entry(part).State = EntityState.Modified;
                db.SaveChanges();
                return 1;
            }
            catch
            {
                throw;
            }
        }

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

        //READ ALL 
        public IEnumerable<Manufacturer> GetAllManufacturers()
        {
            try
            {
                List<Manufacturer> lstManufacturer = new List<Manufacturer>();
                lstManufacturer = (from ManufacturerList in db.Manufacturer select ManufacturerList).ToList();
                return lstManufacturer;
            }
            catch
            {
                throw;
            }
        }

        //UPDATE

        //DELETE
        
        #endregion
    }
}
