using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ClienteServicioV2._0.Models
{
    public partial class Triangle
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("width")]
        public long Width { get; set; }

        [JsonProperty("height")]
        public long Height { get; set; }

        [JsonProperty("area")]
        public double Area { get; set; }

        [JsonProperty("perimeter")]
        public double Perimeter { get; set; }
    }

    public partial class Triangle
    {
        public static Triangle FromJson(string json) => JsonConvert.DeserializeObject<Triangle>(json, ClienteServicioV2._0.Models.Converter.Settings);
    }
}
