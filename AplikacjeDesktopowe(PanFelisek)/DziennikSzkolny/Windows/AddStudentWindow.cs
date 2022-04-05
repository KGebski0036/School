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
    public partial class AddStudentWindow : Form
    {
        public Student CreatedStudent { get; set; }
        public AddStudentWindow(List<SchoolClass> schoolClasses, Student student)
        {
            InitializeComponent();
            UpdateSchoolClass(schoolClasses);
            if (student != null)
            {
                EditStudent(student);
                CreatedStudent = student;
            }
            if(student.Name == "")
            {
                buttonAddStudent.Text = "Zapisz edycję";
            }
        }

        private void EditStudent(Student student)
        {
            textBoxInputImie.Text = student.Name;
            textBoxInputNazwisko.Text = student.SurName;
            comboBoxInputKlasa.SelectedItem = student.Schoolclass;
            numericUpDownInputRok.Value = student.YearOfBirth;
        }

        private void UpdateSchoolClass(List<SchoolClass> schoolClasses)
        {
            comboBoxInputKlasa.DataSource = schoolClasses;
            comboBoxInputKlasa.DisplayMember = "NameOfSchoolClass";
        }

        private void buttonAddStudent_Click(object sender, EventArgs e)
        {
            if (textBoxInputImie.Text == "" &&
                textBoxInputNazwisko.Text == "" &&
                numericUpDownInputRok.Value == 0 &&
                comboBoxInputKlasa.SelectedIndex == 0)
            {
                DialogResult = DialogResult.No;
            }
            else
            {
                DialogResult = DialogResult.Yes;
                CreatedStudent.Name = textBoxInputImie.Text;
                CreatedStudent.SurName = textBoxInputNazwisko.Text;
                CreatedStudent.YearOfBirth = (int)numericUpDownInputRok.Value;
                CreatedStudent.SchoolClassId = (comboBoxInputKlasa.SelectedItem as SchoolClass).Id;
            }
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
