using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BazaDanych.DTO;
using BazaDanych.Modele;
using BazaDanych.Repository;
using static Quizy.Okna_pomocnicze.UCWyswietlPytanie;

namespace Quizy.Zakładki
{
    public partial class UCListaPytan : UserControl
    {
        public ListRepository Repository;
        private PytaneOdpowiedzQuiz aktualnePytanie;
        private List<PytaneOdpowiedzQuiz> listaPobranychPytan = new();
        public UCListaPytan()
        {
            InitializeComponent();
        }

        private void comboBoxListaPytan_SelectedIndexChanged(object sender, EventArgs e)
        {
            ucWyswietlPytanie1.WyswietlPytanie = null;
            if (comboBoxListaPytan.SelectedItem != null)
            {
                int id;
                int.TryParse(comboBoxListaPytan.SelectedItem.ToString(), out id);

                aktualnePytanie = PobierzPytanieOdpowiedz(listaPobranychPytan, id, true);
                ucWyswietlPytanie1.WyswietlPytanie = aktualnePytanie;

            }
        }

        private PytaneOdpowiedzQuiz PobierzPytanieOdpowiedz(List<PytaneOdpowiedzQuiz> lista, int id, bool answerVisible = false)
        {
            PytaneOdpowiedzQuiz result =
                lista.FirstOrDefault(_ => _.PytanieQuiz.readPytanieDTO.Id == id);
            if (result == null)
            {
                result = new PytaneOdpowiedzQuiz();
                lista.Add(result);

                result.PytanieQuiz = new();
                result.PytanieQuiz.readPytanieDTO = Repository.ReadPytanie(id);
                result.PytanieQuiz.TextBoxPytanie = new TextBox()
                {
                    Text = result.PytanieQuiz.readPytanieDTO.TrescPytania,
                    Dock = DockStyle.Fill,
                    Multiline = true,
                    ReadOnly = true
                };
                List<ReadOdpowiedziDTO> odpowiedziDTO = Repository.ReadOdpowiedzi(id);
                result.OdpowiedziLista = odpowiedziDTO.Select(_ => new OdpowiedzQuiz() {
                    OdpowiedziDTO = _,
                    CheckBoxOdpowiedz = new CheckBox()
                    {
                        Text = _.TrescOdpowiedzi,
                        Checked = answerVisible && _.CzyPrawidlowa,
                        Enabled = false
                    }
                }).ToList();

            }
            return result;
        }

        public void RefreshData()
        {
            int aktualnaPozycja = comboBoxListaPytan.SelectedIndex;

            comboBoxListaPytan.SelectedIndexChanged -= comboBoxListaPytan_SelectedIndexChanged;

            comboBoxListaPytan.Items.Clear();

            List<int> listaIDPytan = Repository.ReadPytaniaIdList();
            foreach(int id in listaIDPytan)
            {
                comboBoxListaPytan.Items.Add(id);  
                
            }
            
            comboBoxListaPytan.SelectedIndexChanged += comboBoxListaPytan_SelectedIndexChanged;
            if(comboBoxListaPytan.Items.Count > 0 && aktualnaPozycja < -1)
            {
                aktualnaPozycja = 0;
            }
            comboBoxListaPytan.SelectedIndex = aktualnaPozycja;
        }

        private void buttonUsun_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Czy chcesz usunąć pytanie?","Usuwanie",MessageBoxButtons.YesNo); 
            if(dialogResult == DialogResult.Yes)
            {
                int idPytania = aktualnePytanie.PytanieQuiz.readPytanieDTO.Id;
                Repository.DeleteOdpowiedzi(idPytania);
                Repository.DeletePytanie(idPytania);

                comboBoxListaPytan.SelectedIndexChanged -= comboBoxListaPytan_SelectedIndexChanged;
                int aktualnaPozycja = comboBoxListaPytan.SelectedIndex;

                listaPobranychPytan.Remove(aktualnePytanie);
                comboBoxListaPytan.Items.Remove(comboBoxListaPytan.SelectedItem);

                if(aktualnaPozycja == comboBoxListaPytan.Items.Count)
                {
                    aktualnaPozycja--;
                }
                comboBoxListaPytan.SelectedIndex = aktualnaPozycja;
                comboBoxListaPytan.SelectedIndexChanged += comboBoxListaPytan_SelectedIndexChanged;
                comboBoxListaPytan_SelectedIndexChanged(null, null);

            }
        }
    }
}
