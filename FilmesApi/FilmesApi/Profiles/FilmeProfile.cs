using AutoMapper;
using FilmesApi.Dto;
using FilmesApi.Models;

namespace FilmesApi.Profiles
{
    public class FilmeProfile : Profile
    {
        public FilmeProfile()
        {
            CreateMap<FilmeDto, Filme>();
        }
    }
}
