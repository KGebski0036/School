using BazaDanych.DTO;
using BazaDanych.Mapper;
using BazaDanych.Modele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazaDanych.Repository
{
    public class ListRepository
    {
        List<Pytanie> pytaniaLista;
        List<Odpowiedz> odpowiedziLista;

        QuizAutoMapper quizAutoMapper = new QuizAutoMapper();
        public ListRepository()
        {
            pytaniaLista = new List<Pytanie>();
            odpowiedziLista = new List<Odpowiedz>();

            Pytanie pytanie = new Pytanie();
            pytanie.Id = 0;
            pytanie.TrescPytania = "AAA";
            pytaniaLista.Add(pytanie);

            pytanie = new Pytanie();
            pytanie.Id = 1;
            pytanie.TrescPytania = "Czy można?";
            pytaniaLista.Add(pytanie);

            Odpowiedz odpowiedz = new Odpowiedz();
            odpowiedz.Id = 0;
            odpowiedz.TrescOdpowiedzi = "AA";
            odpowiedz.CzyPrawidlowa = false;
            odpowiedz.IdPytania = 0;
            odpowiedziLista.Add(odpowiedz);

            odpowiedz = new Odpowiedz();
            odpowiedz.Id = 1;
            odpowiedz.TrescOdpowiedzi = "A";
            odpowiedz.CzyPrawidlowa = true;
            odpowiedz.IdPytania = 0;
            odpowiedziLista.Add(odpowiedz);

            odpowiedz = new Odpowiedz();
            odpowiedz.Id = 2;
            odpowiedz.TrescOdpowiedzi = "Można jak najbardziej";
            odpowiedz.CzyPrawidlowa = true;
            odpowiedz.IdPytania = 1;
            odpowiedziLista.Add(odpowiedz);
        }

        #region CRUD

        #region C
        public void CreatePytanie()
        {

        }
        #endregion
        #region R
        public List<ReadPytanieDTO> ReadListaPytan()
        {
            List<ReadPytanieDTO> readPytanieDTOs = new List<ReadPytanieDTO>();
            foreach(Pytanie pytanie in pytaniaLista)
            {
                readPytanieDTOs.Add(quizAutoMapper.Mapper.Map<ReadPytanieDTO>(pytanie));
            }
            return readPytanieDTOs;
        }
        public ReadPytanieDTO ReadPytanie(int id)
        {
            Pytanie pytanie = pytaniaLista.FirstOrDefault(_ => _.Id == id);
            if (pytanie == null)
                throw new Exception("Nie znaleziono pytania");

            ReadPytanieDTO readPytanieDTO = new ReadPytanieDTO();
            readPytanieDTO = quizAutoMapper.Mapper.Map<ReadPytanieDTO>(pytanie);
            return readPytanieDTO;
        }
        public List<ReadOdpowiedziDTO> ReadOdpowiedzi(int idPytania)
        {
            List<Odpowiedz> odpowiedzi = odpowiedziLista.Where(_ => _.IdPytania == idPytania).ToList();
            List<ReadOdpowiedziDTO> result = quizAutoMapper.Mapper.Map<List<ReadOdpowiedziDTO>>(odpowiedzi);
            return result;
        }
        public List<int> ReadPytaniaIdList()
        {
            var result = pytaniaLista.Select(_ => _.Id).ToList();
            return result;
        }
        #endregion
        #region U

        #endregion
        #region D
        public void DeleteOdpowiedzi(int idPytania)
        {
            odpowiedziLista.RemoveAll(_ => _.IdPytania == idPytania);
        }
        public void DeletePytanie(int idPytania)
        {
            pytaniaLista.Remove(new Pytanie() {Id = idPytania});
        }
        #endregion
        #endregion
    }
}
