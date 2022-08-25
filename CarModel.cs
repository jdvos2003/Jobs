using System.Text.Json.Serialization;

namespace CarDescription_Backend.Models
{
    public class CarModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string BodyType { get; set; } = string.Empty;
        public string FuelType { get; set; } = string.Empty;
        public decimal Efficiency { get; set; }
        public decimal StartingPrice { get; set; }
        public bool IsBeingProduced { get; set; }

        public int CarMakerId { get; set; }
        [JsonIgnore]
        public virtual CarMaker CarMaker { get; set; }
    }
}
