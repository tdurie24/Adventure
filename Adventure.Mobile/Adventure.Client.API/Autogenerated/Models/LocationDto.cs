// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Adventure.Client.API.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class LocationDto
    {
        /// <summary>
        /// Initializes a new instance of the LocationDto class.
        /// </summary>
        public LocationDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LocationDto class.
        /// </summary>
        public LocationDto(System.Guid? id = default(System.Guid?), string surburb = default(string), string town = default(string), string province = default(string), string country = default(string), GeoCoordinateDto gpsLocation = default(GeoCoordinateDto))
        {
            Id = id;
            Surburb = surburb;
            Town = town;
            Province = province;
            Country = country;
            GpsLocation = gpsLocation;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public System.Guid? Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "surburb")]
        public string Surburb { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "town")]
        public string Town { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "province")]
        public string Province { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "country")]
        public string Country { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "gpsLocation")]
        public GeoCoordinateDto GpsLocation { get; set; }

    }
}
