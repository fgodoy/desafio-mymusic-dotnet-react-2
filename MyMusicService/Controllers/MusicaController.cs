using System.Threading.Tasks;
using DojoMyMusic.Models;
using Microsoft.AspNetCore.Mvc;

namespace DojoMyMusic.Controllers
{
    [Route("api/[controller]")]
    public class MusicaController : Controller
    {
        private readonly ApplicationDbContext db;
        public MusicaController(ApplicationDbContext db)
        {
            this.db = db;
        }

        public async Task<IActionResult> Get(string filtro)
        {
            throw new System.NotImplementedException();
        }

        // Método com cache no Redis
        public async Task<IActionResult> GetCached(string filtro)
        {
            throw new System.NotImplementedException();
        }
    }
}
