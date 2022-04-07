using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Szkolny_Dziennik.BazaDanych.Models;

namespace Szkolny_Dziennik.Windows
{
    public partial class AddSchoolClas : Form
    {
        public SchoolClass CreatedSchoolClass { get; set; }
        public AddSchoolClas(SchoolClass schoolClas)
        {
            InitializeComponent();
            CreatedSchoolClass = schoolClas;
            if (schoolClas.NameOfSchoolClass != "")
            {
                textBoxInputSchoolClassName.Text = schoolClas.NameOfSchoolClass;
                button2.Text = "Zapisz edycje";
            }   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBoxInputSchoolClassName.Text == "")
            {
                DialogResult = DialogResult.No;
            }
            else
            {
                DialogResult = DialogResult.Yes;
                CreatedSchoolClass.NameOfSchoolClass = textBoxInputSchoolClassName.Text;
            }
            Close();
        }
    }
}
