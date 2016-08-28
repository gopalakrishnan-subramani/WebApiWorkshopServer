using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NodeSenseWebApiWorkshopServer.Models
{
    public class City
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        [Required]
        public string Name { get; set; }
        
        [JsonProperty(PropertyName = "stateId")]
        [Required]
        public int StateId { get; set; }


        [JsonProperty(PropertyName = "updated")]
        public DateTime Updated { get; set; }
    }
}