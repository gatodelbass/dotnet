using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Walking_Simple_API.Models.DTO;
using WebApplication2.Data;
using WebApplication2.Models.Domain;

namespace Walking_Simple_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegionsController : ControllerBase
    {

        private readonly TheDBContext dbContext;

        public RegionsController(TheDBContext dbContect)
        {
            this.dbContext = dbContect;
        }


        [HttpGet]
        public IActionResult GetAll() {
            //get the data from database table
            var regions = dbContext.Regions.ToList();
            var regionsDto = new List<RegionDto>();

            // the retrieved data is mapped in the DTOs
            foreach (var region in regions)
            {
                regionsDto.Add(new RegionDto() {
                    Id = region.Id,
                    Code = region.Code,
                    Name = region.Name,
                    RegionImageUrl = region.RegionImageUrl,
                });
            }

            //return DTOs
            return Ok(regionsDto);
        }

        //get region by id
        [HttpGet]
        [Route("{id:guid}")]
        public IActionResult GetById([FromRoute] Guid id) 
        {
            var region = dbContext.Regions.Find(id);

            if (region == null)
            {
                return NotFound();
            }
            else {
                return Ok(region);
            }
            
        }

    }
}
