using Microsoft.AspNetCore.Mvc;
using MorePlants_PlantsAPI.Data;
using MorePlants_PlantsAPI.Models;
using MorePlants_PlantsAPI.Models.Dto;

namespace MorePlants_PlantsAPI.Controllers
{

    // PlantsAPIController 컨트롤러에 라우팅 어트리뷰 추가해서 라우팅 오류 해결 
    [Route("api/PlantAPI")]
    [ApiController]
    public class PlantAPIController : ControllerBase
    {
        // 여기에 엔드포인트 메서드를 추가할 수 있습니다.


        //[HttpGet]
        //public IEnumerable<PlantDTO> GetPlants()
        //{
        //    return new List<PlantDTO>
        //    {
        //        new PlantDTO { Id = 1, Name = "여인초" },
        //        new PlantDTO { Id = 2, Name = "뱅갈고무나무" }
        //    };
        //}

        // PlantsAPIController 내에서 PlantStore 사용
        [HttpGet]
        public IEnumerable<PlantDTO> GetPlants()
        {
            return PlantStore.PlantList;
        }
    }
}
