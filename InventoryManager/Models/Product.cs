using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager.Models
{
    /*This class represents the model for the database stored products*/

    public class Product
    {
        //Index
        public ObjectId Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public DateTime AcquisitionDate {  get; set; }
        public DateTime ExpirationDate { get; set; }
        public DateTime UnboxingDate { get; set; }
        public DateTime PackageExpirationDate { get; set; }
        public int Price { get; set; }
        public int Stock { get; set; }
        public string Brand { get; set; }
    }
}
