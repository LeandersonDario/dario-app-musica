using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MusicApp.API.Model;
using MusicApp.API.Repository;
using MusicApp.API.ViewModel.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlbumController : ControllerBase
    {
        private AlbumRepository Repository { get; init; }//pode utilizar o set ou init( o init é somente na asp core 5)

        private IMapper Mapper { get; set; }

        public AlbumController(AlbumRepository repository, IMapper mapper)
        {
            this.Repository = repository;
            Mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAlbuns()
        {
            return Ok(await this.Repository.GetAllAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAlbum(Guid id)
        {
            var result = await this.Repository.GetAlbumByIdAsync(id);

            if (result == null)
                return NotFound();

            return Ok(result);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<IActionResult> SaveAlbuns(AlbumRequest request)
        {
            if (ModelState.IsValid == false)
                return BadRequest(ModelState);

            Album album = this.Mapper.Map<Album>(request);

            await this.Repository.CreateAsync(album);

            return Created($"/{album.Id}", album);

        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> DeleteAlbum(Guid id)
        {
            var result = await this.Repository.GetAlbumByIdAsync(id);

            if (result == null)
                return NotFound();

            await this.Repository.DeleteAsync(result);

            return NoContent();
        }

    }
}
