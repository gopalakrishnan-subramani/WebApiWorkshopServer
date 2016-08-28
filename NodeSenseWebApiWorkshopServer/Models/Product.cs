using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NodeSenseWebApiWorkshopServer.Models
{
    public class Product
    {

        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        [Required]
        public string Name { get; set; }
        

        [JsonProperty(PropertyName = "os")]
        public string OS { get; set; }



        [JsonProperty(PropertyName = "ram")]
        public string RAM { get; set; }



        [JsonProperty(PropertyName = "size")]
        public string Size { get; set; }



        [JsonProperty(PropertyName = "storage")]
        public string Storage { get; set; }


        [JsonProperty(PropertyName = "weight")]
        public string Weight { get; set; }


        [JsonProperty(PropertyName = "year")]
        [Required]
        public int Year { get; set; }
         

        [JsonProperty(PropertyName = "camera")]
        public string Camera { get; set; }


        [JsonProperty(PropertyName = "cpu")]
        public string CPU { get; set; }


        [JsonProperty(PropertyName = "gpu")]
        public string GPU { get; set; }
         

        [JsonProperty(PropertyName = "display")]
        public string Display { get; set; }
        

        [JsonProperty(PropertyName = "price")]
        [Required]
        public decimal Price { get; set; }

         
        [JsonProperty(PropertyName = "brandId")]
        [Required]
        public decimal BrandId { get; set; }
         

        [JsonProperty(PropertyName = "updated")]
        public DateTime Updated { get; set; }

    }
}
 