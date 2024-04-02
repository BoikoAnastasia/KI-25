namespace KI_25
{
    public class ShopData
    {
        [Newtonsoft.Json.JsonProperty("id")]
        public int[] id { get; set; }

        [Newtonsoft.Json.JsonProperty("Name")]
        public string[] Name { get; set; }

        [Newtonsoft.Json.JsonProperty("Cost")]
        public double[] Cost { get; set; }

        [Newtonsoft.Json.JsonProperty("Description")]
        public string[] Description { get; set; }
    }
}
