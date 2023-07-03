using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MobileAPI.Model.Domain;

namespace MobileAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MobileController : ControllerBase
    {
        private List<MobileModel> Mobiles = new List<MobileModel>
        {
            new MobileModel{ Id = 1, Name = "Redmi Note 10 Pro", Description = "Best in Class.", Price= 19000, Color="Black", Discount= 1.2f, MobileImageUrl="https://m.media-amazon.com/images/I/61GQAkqz0iL.jpg"},
            new MobileModel{ Id = 2, Name = "Apple 14 Pro", Description = "New Beginning.", Price= 90000, Color="Product Red", Discount= 2.3f, MobileImageUrl="https://store.storeimages.cdn-apple.com/4668/as-images.apple.com/is/iphone-14-pro-finish-select-202209-6-1inch-deeppurple_AV1_GEO_EMEA?wid=5120&hei=2880&fmt=p-jpg&qlt=80&.v=1661969351334"},
            new MobileModel{ Id = 3, Name = "One Plus 7 Pro", Description = "Never Settle.", Price= 60000, Color="Grey Silver", Discount= 4.2f, MobileImageUrl="https://cdn.dxomark.com/wp-content/uploads/medias/post-29313/OnePlus-7-pro_Main-Camera-1200%C3%979001-1024x768.jpg"},
            new MobileModel{ Id = 4, Name = "Samsung S22 Ultra", Description = "Behind the Moon.", Price= 98000, Color="Glossy Red", Discount= 1.4f, MobileImageUrl="https://cdn.dxomark.com/wp-content/uploads/medias/post-106688/Samsung-Galaxy-S22-Ultra-featured-image-packshot-review-Recovered.jpg"},
            new MobileModel{ Id = 5, Name = "Sony Xperia Pro", Description = "El Classico.", Price= 70000, Color="Matfinish Black", Discount= 3.2f, MobileImageUrl="https://s3b.cashify.in/gpro/uploads/2021/04/27131751/sony-xperia-z-ultra-front.png"}

        };

        // https://localhost:7188/api/Mobile
        [HttpGet]
        public ActionResult<IEnumerable<MobileModel>> GetMobile()
        {
            return Ok(Mobiles);
        }

        [HttpGet("{id}")]
        public ActionResult<MobileModel> GetMobile(int id)
        {
            MobileModel mobile = Mobiles.FirstOrDefault(m => m.Id == id);
            if (mobile == null)
            {
                return NotFound(new { Message = "Mobile with entered ID not found." });
            }
            return Ok(mobile);
        }

        [HttpPost]
        public ActionResult<IEnumerable<MobileModel>> PostMobile(MobileModel newMobile)
        {
            Mobiles.Add(newMobile);
            return Ok(Mobiles);
        }

        [HttpPut("{id}")]
        public ActionResult<IEnumerable<MobileModel>> PutMobile(int id, MobileModel updatedMobile)
        {
            foreach (MobileModel m in Mobiles)
            {
                if (m.Id == id)
                {
                    m.Name = updatedMobile.Name;
                    m.Price = updatedMobile.Price;
                    m.Color = updatedMobile.Color;
                    m.Description = updatedMobile.Description;
                    m.Discount = updatedMobile.Discount;
                    m.MobileImageUrl = updatedMobile.MobileImageUrl;
                    return Ok(Mobiles);
                }

            }
            return NotFound(new { Message = "For the Updation Id not Matched ." });
        }

        [HttpDelete("{id}")]
        public ActionResult<IEnumerable<MobileModel>> DeleteMobile(int id)
        {
            foreach (MobileModel m in Mobiles)
            {
                if (m.Id == id)
                {
                    Mobiles.Remove(m);
                    return Ok(Mobiles);
                }

            }
            return NotFound(new { Message = "For the Deletion Id not Matched ." });
        }
    }
}
