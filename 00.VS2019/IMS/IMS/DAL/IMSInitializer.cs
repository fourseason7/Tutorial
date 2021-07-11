using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IMS.Models;

namespace IMS.DAL
{
    public class IMSInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<IMSDBContext>
    {
        protected override void Seed(IMSDBContext db)
        {
            var categories = new List<ProductCategory>
            {
                new ProductCategory{Name="Bullsone", Description="Bullsone"}
                , new ProductCategory{Name="Phone Accessory", Description="Phone Accessory"}
                , new ProductCategory{Name="HAT", Description="HAT"}
                , new ProductCategory{Name="Sunglasses", Description="Sunglasses"}
                , new ProductCategory{Name="CAR Items", Description="CAR Items"}
            };

            db.SaveChanges();
        }
    }
}