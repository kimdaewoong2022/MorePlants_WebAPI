using MorePlants_PlantsAPI.Models.Dto;

namespace MorePlants_PlantsAPI.Data
{
    public static class PlantStore
    {
        public static List<PlantDTO> PlantList = new List<PlantDTO>
        {
            new PlantDTO { Id = 1, Name = "여인초" },
            new PlantDTO { Id = 2, Name = "뱅갈고무나무" }
        };
    }
}
