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

        // 3-1. 엔드포인트에서의 상태 코드
        [HttpGet]
        public ActionResult<IEnumerable<PlantDTO>> GetPlants()
        {
            return Ok(PlantStore.PlantList);
        }

        // 3-2. 응답 타입
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("id:int")]
        public ActionResult<PlantDTO> GetPlant(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }

            var plant = PlantStore.PlantList.FirstOrDefault(u => u.Id == id);

            if (plant == null)
            {
                return NotFound();
            }
            
            return Ok(plant);
        }

        // 3-3. HttpPOST 작업
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<PlantDTO> CreatePlant([FromBody] PlantDTO plantDTO)
        {
            if (plantDTO == null)
            {
                return BadRequest();
            }

            if (plantDTO.Id > 0)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }

            // ID 할당 및 PlantList에 추가 로직...
            plantDTO.Id = PlantStore.PlantList.OrderByDescending(u => u.Id).FirstOrDefault().Id + 1;
            PlantStore.PlantList.Add(plantDTO);

            return Ok(plantDTO);
        }
    }
}
