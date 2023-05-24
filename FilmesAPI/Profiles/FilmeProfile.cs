using AutoMapper;
using FilmesAPI.Data.DTO;
using FilmesAPI.Models;

namespace FilmesAPI.Profiles;

public class FilmeProfile : Profile
{
    public FilmeProfile() {

        CreateMap<createFilmeDTO, Filme>();
        CreateMap<updateFilmeDTO, Filme>();
        CreateMap<Filme, updateFilmeDTO>();
        CreateMap<Filme, readFilmeDTO>();

    }
}
