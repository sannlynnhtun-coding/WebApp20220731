using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApp20220731.EFDbContext;

namespace WebApp20220731.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegionController : ControllerBase
    {
        [HttpGet]
        public async Task<List<Tbl_Region>> GetRegions()
        {
            AppDbContext db = new AppDbContext();
            List<Tbl_Region> lst = await db.Regions.ToListAsync();
            return lst;
        }

        [HttpPost]
        public async Task<Tbl_Region> AddRegions(Tbl_Region region)
        {
            AppDbContext db = new AppDbContext();
            await db.Regions.AddAsync(region);
            await db.SaveChangesAsync();
            return region;
        }
    }
}
