using System.Collections.Generic;
using Newtonsoft.Json;

namespace Demo_Project.Domain.Entities.Location
{
    public class LocationEntity
    {
        [JsonProperty("latitudeE7")]
        public int LatitudeE7 { get; set; }

        [JsonProperty("longitudeE7")]
        public int LongitudeE7 { get; set; }
    }

    public class RootLocationEntity
    {
        [JsonProperty("locations")]
        public List<LocationEntity> Locations { get; set; }
    }
}
