using BazaDanych.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quizy.Okna_pomocnicze
{
    public partial class UCWyswietlPytanie : UserControl
    {
        public PytaneOdpowiedzQuiz WyswietlPytanie
        {
            set
            {
                panel2.Controls.Clear();
                flowLayoutPanelOdpowiedzi.Controls.Clear();
                if(value != null)
                {
                    panel2.Controls.Add(value.PytanieQuiz.TextBoxPytanie);
                    foreach(OdpowiedzQuiz odpowiedz in value.OdpowiedziLista)
                    {
                        flowLayoutPanelOdpowiedzi.Controls.Add(odpowiedz.CheckBoxOdpowiedz);
                    }
                }
            }
        }
        public UCWyswietlPytanie()
        {
            InitializeComponent();
        }
        public class PytaneOdpowiedzQuiz
        {
            public PytanieQuiz PytanieQuiz { get; set; }
            public List<OdpowiedzQuiz> OdpowiedziLista { get; set; }
        }
        public class PytanieQuiz
        {
            public ReadPytanieDTO readPytanieDTO { get; set; }
            public TextBox TextBoxPytanie { get; set; }
        }
        public class OdpowiedzQuiz
        {
            public ReadOdpowiedziDTO OdpowiedziDTO { get; set; }    
            public CheckBox CheckBoxOdpowiedz { get; set;}

        }
    }
}
