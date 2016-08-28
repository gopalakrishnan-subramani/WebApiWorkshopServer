using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NodeSenseWebApiWorkshopServer.Models
{
    public class State
    {
        
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        [Required]
        public string Name { get; set; }


        [JsonProperty(PropertyName = "code")]
        [Required]
        public string Code { get; set; }


        [JsonProperty(PropertyName = "updated")]
        public DateTime Updated { get; set; }
    }
}