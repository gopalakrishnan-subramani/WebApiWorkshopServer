using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NodeSenseWebApiWorkshopServer.Models
{
    public class Store
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        [Required]
        public string Name { get; set; }


        [JsonProperty(PropertyName = "phone")]
        [Required]
        public string Phone { get; set; }


        [JsonProperty(PropertyName = "email")]
        [Required]
        public string Email { get; set; }


        [JsonProperty(PropertyName = "address")]
        [Required]
        public string Address { get; set; }


        [JsonProperty(PropertyName = "pincode")]
        [Required]
        public string PinCode { get; set; }


        [JsonProperty(PropertyName = "stateId")]
        [Required]
        public int StateId { get; set; }

        [JsonProperty(PropertyName = "cityId")]
        [Required]
        public int CityId { get; set; }




        [JsonProperty(PropertyName = "updated")]
        public DateTime Updated { get; set; }
    }
}