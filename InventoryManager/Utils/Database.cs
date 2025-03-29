using InventoryManager.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace InventoryManager.Utils
{
    public class Database
    {


        private static string connectionUri = "mongodb+srv://admin:admin@inventorymanagement.rchgvj6.mongodb.net/?retryWrites=true&w=majority&appName=InventoryManagement";

        public static MongoClient? DatabaseClient { get; set; }
        public static IMongoDatabase? MongoDatabase { get; set; }


        public static void Initialize()
        {
            try
            {
                if (DatabaseClient == null)
                {
                    DatabaseClient = new MongoClient(connectionUri);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public static void LoadDatabase(string databaseName)
        {
            MongoDatabase = DatabaseClient?.GetDatabase(databaseName);
        }



        public static void InsertDocument<T>(T document, string collectionName)
        {
            if (MongoDatabase != null)
            {
                var collection = MongoDatabase.GetCollection<T>(collectionName);
                collection.InsertOne(document);
            }
        }
    }
}
