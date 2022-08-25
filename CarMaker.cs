namespace CarDescription_Backend.Models
{
    public class CarMaker
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public virtual List<CarModel> CarModels { get; set; }
    }
}
