using AutoMapper;
using Biblioteca.Dtos;
using Biblioteca.Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace Biblioteca.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutoresController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public AutoresController(ApplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<AutorDto>>> Listar()
        {
            var autores = await context.Autores.ToListAsync();

            var autoresDto = mapper.Map<List<AutorDto>>(autores);

            return autoresDto;
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<AutorDto>> ObtenerPorId(int id)
        {
            var autor = await context.Autores.FirstOrDefaultAsync(x => x.Id == id);

            if (autor == null)
            {
                return NotFound();
            }

            var autorDto = mapper.Map<AutorDto>(autor);

            return autorDto;
        }
    }
}
