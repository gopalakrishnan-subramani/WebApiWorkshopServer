using Newtonsoft.Json.Linq;
using NodeSenseWebApiWorkshopServer.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.IO;
using System.Linq;
using System.Web;

namespace NodeSenseWebApiWorkshopServer.Migrations
{
    //Open Tools, NuGet Package Managers
    //Enable-Migrations
    //Add-Migration initial
    //Update-Database


    //BEWARE: This delete your local DB, sue with caution
    //sqllocaldb.exe stop
    //sqllocaldb.exe delete 

    internal sealed partial class Seeder// : DbMigrationsConfiguration<NodeSenseWebApiWorkshopServer.Models.DataContext>
    {



        public static void SeedData(NodeSenseWebApiWorkshopServer.Models.DataContext context)
        {
            SeedCities(context);
            SeedStates(context);
            SeedBrands(context);
            SeedProducts(context);
        }

        public static void SeedCities(NodeSenseWebApiWorkshopServer.Models.DataContext context)
        {
            string path = AppDomain.CurrentDomain.GetData("DataDirectory").ToString();


            JObject citiesJson = JObject.Parse(File.ReadAllText(path + "/cities.json"));

            JArray cities = (JArray)citiesJson["cities"];

            DateTime timeNow = DateTime.Now;
             

            foreach(JObject o in cities)
            {
                JToken id = o["id"];

                City city = new City();
                city.Id = o["id"].Value<int>();
                city.Name = o["name"].Value<string>();
                city.StateId = o["stateId"].Value<int>();
                city.Updated = timeNow;

                
                if (context != null)
                {

                    context.Cities.AddOrUpdate(
                    c => c.Id,
                    city
                   );

                    Console.WriteLine("Updated city {0}-{1}", city.Id, city.Name);

                }
            }
             
        }


        public static void SeedStates(NodeSenseWebApiWorkshopServer.Models.DataContext context)
        {
            string path = AppDomain.CurrentDomain.GetData("DataDirectory").ToString();


            JObject statesJson = JObject.Parse(File.ReadAllText(path + "/states.json"));

            JArray states = (JArray)statesJson["states"];

            DateTime timeNow = DateTime.Now;


            foreach (JObject o in states)
            {
                JToken id = o["id"];

                State state = new State();
                state.Id = o["id"].Value<int>();
                state.Name = o["name"].Value<string>();
                state.Code = o["code"].Value<string>();
                state.Updated = timeNow;


                if (context != null)
                {
                    context.States.AddOrUpdate(
                        c => c.Id,
                        state
                    );

                    Console.WriteLine("Updated state {0}-{1}", state.Id, state.Name);

                }
            }
        }



        public static void SeedBrands(NodeSenseWebApiWorkshopServer.Models.DataContext context)
        {
            string path = AppDomain.CurrentDomain.GetData("DataDirectory").ToString();


            JObject brandsJson = JObject.Parse(File.ReadAllText(path + "/brands.json"));

            JArray brands = (JArray)brandsJson["brands"];

            DateTime timeNow = DateTime.Now;


            foreach (JObject o in brands)
            {
                JToken id = o["id"];

                Brand brand = new Brand();
                brand.Id = o["id"].Value<int>();
                brand.Name = o["name"].Value<string>();
                brand.Updated = timeNow;


                if (context != null)
                {
                    context.Brands.AddOrUpdate(
                        c => c.Id,
                        brand
                    );

                    Console.WriteLine("Updated state {0}-{1}", brand.Id, brand.Name);

                }
            }
        }




        public static void SeedProducts(NodeSenseWebApiWorkshopServer.Models.DataContext context)
        {
            string path = AppDomain.CurrentDomain.GetData("DataDirectory").ToString();


            JObject productsJson = JObject.Parse(File.ReadAllText(path + "/products.json"));

            JArray products = (JArray) productsJson["products"];

            DateTime timeNow = DateTime.Now;

            Random priceGenerator = new Random();

            foreach (JObject o in products)
            {
                JToken id = o["id"];

                Product product = new Product();
                product.Id = o["id"].Value<int>();
                product.Name = o["name"].Value<string>();


                product.OS = o["os"].Value<string>();
                product.RAM = o["ram"].Value<string>();
                product.Size = o["size"].Value<string>();
                product.Storage = o["storage"].Value<string>();
                product.Weight = o["weight"].Value<string>();

                product.Year = o["year"].Value<int>();


                product.Camera = o["camera"].Value<string>();

                product.CPU = o["cpu"].Value<string>();

                product.GPU = o["gpu"].Value<string>();

                product.Display = o["display"].Value<string>();

                //product.Price = o["price"].Value<decimal>();

                product.Price = priceGenerator.Next(100, 300);

                product.BrandId = o["brandId"].Value<int>();

        

                product.Updated = timeNow;


                if (context != null)
                {
                    context.Products.AddOrUpdate(
                        c => c.Id,
                        product
                    );

                    Console.WriteLine("Updated state {0}-{1}", product.Id, product.Name);

                }
            }
        }


    }
}