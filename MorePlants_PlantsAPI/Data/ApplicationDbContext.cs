using Microsoft.EntityFrameworkCore;
using MorePlants_PlantsAPI.Models;

namespace MorePlants_PlantsAPI.Data
{    
    public class ApplicationDbContext : DbContext
    {
        //4-5. 연결 문자열 사용
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Plant> Plants { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Plant>().HasData(
                new Plant
                {
                    Id = 1,
                    Name = "여인초",
                    Details = "여인초는 마다가스카르 원산지로 플랜테리어 실내조경 인테리어 식물로 꾸준히 많은 사랑을 받고 있습니다.",
                    ImageUrl = "https://shop-phinf.pstatic.net/20231110_61/1699592764107jn9o8_JPEG/23118954104082569_1998215622.jpg?type=m510",
                    Occupancy = 4,
                    Rate = 200,
                    Size = 550,
                    CreatedDate = DateTime.Now
                },
              new Plant
              {
                  Id = 2,
                  Name = "뱅갈고무나무",
                  Details = "실내에서도 튼튼하고 싱그러운 잎이 매력적인 '뱅갈고무나무'는 열대성 관상수로 다양한 카페 매장이나 사무실 등의 플랜테리어 식물로 많은 사랑을 받고 있습니다.",
                  ImageUrl = "https://shop-phinf.pstatic.net/20231109_39/1699514252955SFGey_JPEG/51586640329505362_16946473.jpg?type=m510",
                  Occupancy = 4,
                  Rate = 300,
                  Size = 550,
                  CreatedDate = DateTime.Now
              },
              new Plant
              {
                  Id = 3,
                  Name = "휘커스움베르타",
                  Details = "휘커스움베르타는 무화과나무속 아프리카 원산지로 플랜테리어 실내조경 인테리어 식물로 꾸준히 많은 사랑을 받고 있습니다.",
                  ImageUrl = "https://shop-phinf.pstatic.net/20240202_296/1706848835240pVrYo_JPEG/34151519097359293_895289601.jpg?type=m510",
                  Occupancy = 4,
                  Rate = 400,
                  Size = 450,
                  CreatedDate = DateTime.Now
              },
              new Plant
              {
                  Id = 4,
                  Name = "아레카야자",
                  Details = "아레카 야자는 마다가스카르 원산지로 카페 매장이나 사무실 등에 배치하면 좋으며 플랜테리어 인테리어 식물로 꾸준히 많은 사랑을 받고 있습니다.",
                  ImageUrl = "https://shop-phinf.pstatic.net/20240131_46/1706676785751F0ecb_JPEG/107812684413121543_403150541.jpg?type=m510",
                  Occupancy = 4,
                  Rate = 550,
                  Size = 600,
                  CreatedDate = DateTime.Now
              },
              new Plant
              {
                  Id = 5,
                  Name = "크로톤",
                  Details = "크로톤은 화려하고 다채로운 색상의 건강한 잎을 지니고 있어 실내 인테리어 환경과 잘 어울리며, 관상용으로 뛰어나 승진이나 개업선물용으로 사랑받는 식물입니다.",
                  ImageUrl = "https://shop-phinf.pstatic.net/20231013_237/1697184041025Ioq5O_PNG/44331539823884559_499226285.png?type=m510",
                  Occupancy = 4,
                  Rate = 600,
                  Size = 550,
                  CreatedDate = DateTime.Now
              });
        }
    }
}
