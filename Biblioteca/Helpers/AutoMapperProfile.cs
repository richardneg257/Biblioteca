using AutoMapper;
using Biblioteca.Dtos;
using Biblioteca.Entidades;

namespace Biblioteca.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Autor, AutorDto>().ReverseMap();
        }
    }
}
