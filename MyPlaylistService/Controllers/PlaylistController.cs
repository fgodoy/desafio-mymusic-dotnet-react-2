using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DojoMyPlaylist.Models;
using Microsoft.EntityFrameworkCore;

namespace DojoMyPlaylist.Controllers
{
    [Route("api/[controller]")]
    public class PlaylistController : Controller
    {
        private readonly ApplicationDbContext db;

        public PlaylistController(ApplicationDbContext db)
        {
            this.db = db;
        }

        public async Task<IActionResult> GetByUser(string usuario)
        {
            throw new System.NotImplementedException();
        }

        [HttpPut("AddMusica/{usuarioId}")]
        public async Task<IActionResult> PutAddMusic(string usuarioId, [FromBody]Musica value)
        {
            throw new System.NotImplementedException();
        }

        [HttpPut("RemoveMusica/{playlistId}")]
        public async Task PutRemoveMusic(string playlistId, [FromBody]Musica value)
        {
            throw new System.NotImplementedException();
        }
    }
}
