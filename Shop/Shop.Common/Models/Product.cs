

namespace Shop.Common.Models
{
    using Newtonsoft.Json;
using System;
    public class Product
    {
        [JsonProperty("id")]
        public int Id;

        [JsonProperty("name")]
        public string Name;

        [JsonProperty("apellidos")]
        public string Apellidos;

        [JsonProperty("imageUrl")]
        public string ImageUrl;

        [JsonProperty("lastPurchase")]
        public DateTime LastPurchase;

        [JsonProperty("lastSale")]
        public DateTime LastSale;

        [JsonProperty("isAvailabe")]
        public object IsAvailabe;

        [JsonProperty("stock")]
        public double Stock;

        [JsonProperty("user")]
        public User User;

        [JsonProperty("imageFullPath")]
        public string ImageFullPath;
    }
}
