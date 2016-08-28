using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NodeSenseWebApiWorkshopServer.Migrations;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace NodeSenseWebApiWorkshopServer
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {

            Console.WriteLine("Loading Object");



            Seeder.SeedData(null);
            
            


            GlobalConfiguration.Configure(WebApiConfig.Register);

             
             

            //AntiForgeryConfig.UniqueClaimTypeIdentifier = ClaimTypes.Email;

        }
    }
}
