using System;
using DAL;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Begin:");

            //CreateManufacturer();
            //ReadManufacturer();
            CreatePart();
            ReadPart();

            Console.WriteLine("End:");
            Console.ReadKey();
        }

        public static void CreateManufacturer()
        {
            using (var db = new DALContext())
            {
                db.Manufacturer.Add(new DAL.Models.Manufacturer { Name = "Delco" });
                db.Manufacturer.Add(new DAL.Models.Manufacturer { Name = "Chrysler" });
                db.Manufacturer.Add(new DAL.Models.Manufacturer { Name = "Dodge" });
                db.Manufacturer.Add(new DAL.Models.Manufacturer { Name = "Ford" });
                var count = db.SaveChanges();
                Console.WriteLine("{0} records saved to database", count);
            }
        }

        public static void ReadManufacturer()
        {
            using (var db = new DALContext())
            {
                foreach (var manufacturer in db.Manufacturer)
                {
                    Console.WriteLine("{0}", manufacturer.Name);
                }
            }
        }

        public static void CreatePart()
        {
            using (var db = new DALContext())
            {
                db.Part.Add(new DAL.Models.Part { Number = "00001", ManufacturerID = 1, Name = "SPK", Description = "Ignites gas in the engine cylinder" });
                db.Part.Add(new DAL.Models.Part { Number = "00002", ManufacturerID = 1, Name = "LRP", Description = "Truck Left Rear Passenger Panel" });
                db.Part.Add(new DAL.Models.Part { Number = "00003", ManufacturerID = 1, Name = "RRP", Description = "Truck Right Rear Passenger Panel" });
                var count = db.SaveChanges();
                Console.WriteLine("{0} records saved to database", count);
            }
        }

        public static void ReadPart()
        {
            using (var db = new DALContext())
            {
                foreach (var part in db.Part)
                {
                    Console.WriteLine("{0}", part.Name);
                }
            }
        }

    }
}
