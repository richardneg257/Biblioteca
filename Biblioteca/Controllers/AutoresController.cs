using AutoMapper;
using Biblioteca.Dtos;
using Biblioteca.Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;

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
        public List<AutorDto> Listar()
        {
            var autores = context.Autores.ToList();

            var autoresDto = mapper.Map<List<AutorDto>>(autores);

            return autoresDto;
        }
    }
}
