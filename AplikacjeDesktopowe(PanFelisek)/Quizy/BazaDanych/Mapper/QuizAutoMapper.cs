using AutoMapper;
using BazaDanych.DTO;
using BazaDanych.Modele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazaDanych.Mapper
{
    public class QuizAutoMapper
    {
        public IMapper Mapper { get; set; }
        private MapperConfiguration configuration;
        public QuizAutoMapper()
        {
            configuration = new MapperConfiguration(ConfigAutomapper);
            Mapper = configuration.CreateMapper();
        }

        private void ConfigAutomapper(IMapperConfigurationExpression obj)
        {
            obj.CreateMap<Pytanie, ReadPytanieDTO>();
            obj.CreateMap<Odpowiedz, ReadOdpowiedziDTO>();
        }
    }
}
