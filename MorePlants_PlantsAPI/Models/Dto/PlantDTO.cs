using System.ComponentModel.DataAnnotations;

namespace MorePlants_PlantsAPI.Models.Dto
{
    public class PlantDTO
    {
        public int Id { get; set; }

        // 3-5. ModelState 유효성 검사
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
    }
}
