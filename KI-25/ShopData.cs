namespace KI_25
{
    public class ShopData
    {
        [Newtonsoft.Json.JsonProperty("Id")]
        public int[] Id { get; set; }

        [Newtonsoft.Json.JsonProperty("Name")]
        public string[] Name { get; set; }

        [Newtonsoft.Json.JsonProperty("Cost")]
        public double[] Cost { get; set; }

        [Newtonsoft.Json.JsonProperty("Description")]
        public string[] Description { get; set; }
    }
}
