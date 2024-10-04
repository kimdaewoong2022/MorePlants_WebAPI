namespace MorePlants_PlantsAPI.Models
{
    public class Plant
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Details { get; set; }
        public double Rate { get; set; }
        public int Size { get; set; }
        public int Occupancy { get; set; }
        public string ImageUrl { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
