using MasaBomby.BazaDanych.Context;
using MasaBomby.BazaDanych.Modele;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasaBomby
{
    public partial class OknoGlowne : Form
    {
        ConvertorDbContext convertorDbContext;

        public OknoGlowne()
        {
            InitializeComponent();
            convertorDbContext = new ConvertorDbContext();
            UpdateUnitsType();
            UpdateUnits();
        }

        private void UpdateUnitsType()
        {
            comboBoxRodzajJednostek.DataSource = convertorDbContext.TypeOfUnits.ToList();
            comboBoxRodzajJednostek.DisplayMember = "Name";
        }

        private void UpdateUnits()
        {
            RodzajeJednostek rodzaj = comboBoxRodzajJednostek.SelectedItem as RodzajeJednostek;
            comboBoxUnitFrom.DataSource = convertorDbContext.Units.Where(x => x.RodzajeJednostekId == rodzaj.Id).ToList();
            comboBoxUnitFrom.DisplayMember = "Name";

           UpadateJednostiTo();
        }

        private void comboBoxRodzajJednostek_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateUnits();
        }

        private void comboBoxUnitFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpadateJednostiTo();
            Calculate();
        }

        private void UpadateJednostiTo()
        {
            Jednostki a = comboBoxUnitFrom.SelectedItem as Jednostki;
            if (a != null)
            {
                var jednostki = convertorDbContext.Units.Where(x => x.Id != a.Id && x.RodzajeJednostekId == a.RodzajeJednostekId).ToList();
                comboBoxUnitTo.DataSource = jednostki.ToList();
                comboBoxUnitTo.DisplayMember = "Name";
            }
            else
            {
                comboBoxUnitTo.DataSource = null;
            }
        }

        private void numericUpDownInput_ValueChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calculate();
        }

        private void Calculate()
        {
            string wynik = "";
            string disclamer = " = ";

            double UnitFromNumber = ((double)numericUpDownInput.Value);

            Jednostki unitFrom = comboBoxUnitFrom.SelectedItem as Jednostki;
            wynik = UnitFromNumber.ToString() + unitFrom.CharRepresentation;

            wynik += disclamer;

            Jednostki unitTo = comboBoxUnitTo.SelectedItem as Jednostki;
            Przelicznik multipler = convertorDbContext.Convertors.FirstOrDefault(x => x.UnitFromId == unitFrom.Id && x.UnitToId == unitTo.Id);
            if (multipler != null)
            {
                double UnitToNumber = UnitFromNumber * multipler.Multiplier;
                wynik += UnitToNumber.ToString() + unitTo.CharRepresentation;
            }
            else
            {
                MessageBox.Show("Cos poszlo nie tak");
            }

            labelWynik.Text = wynik;

        }

    }
}
