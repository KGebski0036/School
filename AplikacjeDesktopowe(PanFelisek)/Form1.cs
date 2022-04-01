using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Szkolny_Dziennik.BazaDanych.Context;
using Szkolny_Dziennik.BazaDanych.Models;
using Szkolny_Dziennik.Models;
using Szkolny_Dziennik.Windows;

namespace Szkolny_Dziennik
{
    public partial class Form1 : Form
    {
        StudentsDataBase studentsDataBase;
        Filters filters;
        public Form1()
        {
            studentsDataBase = new StudentsDataBase();
            filters = new Filters() { Name = "", SchoolClass = -1, SurName = "", YearOfBirth = 0 };
            InitializeComponent();
            dataGridViewUczniowie.AutoGenerateColumns = false;
            UpdateStudents();
            UpdateSchoolClass();
        }

        private void UpdateSchoolClass()
        {
            List<SchoolClass> displayList = studentsDataBase.SchoolClasses.ToList();
            displayList.Insert(0, new SchoolClass() { Id = 0, NameOfSchoolClass = "<Wszystkie>" });
            comboBoxSchoolClass.DataSource = displayList;
            comboBoxSchoolClass.DisplayMember = "NameOfSchoolClass";
        }

        private void UpdateStudents()
        {
            var listaW = studentsDataBase.Students.Include(x => x.Schoolclass);
            addFilters(listaW);
        }

        private void addFilters(IIncludableQueryable<Student, SchoolClass> studentsList)
        {
            IQueryable<Student> students = studentsList.Where(x => true);

            if (filters.Name != "")
            {

                students = students.Where(x => x.Name.Contains(filters.Name));
            }
            if (filters.SurName != "")
            {

                students = students.Where(x => x.SurName.Contains(filters.SurName));
            }
            if (filters.SchoolClass != -1)
            {
                students = students.Where(x => x.SchoolClassId == filters.SchoolClass);
            }
            if (filters.YearOfBirth != 0)
            {
                students = students.Where(x => x.YearOfBirth == filters.YearOfBirth);
            }
            dataGridViewUczniowie.DataSource = students
                .Select(x => new StudentsView
                {
                    Name = x.Name,
                    SurName = x.SurName,
                    YearOfBirth = x.YearOfBirth,
                    SchoolClass = x.Schoolclass.NameOfSchoolClass
                }).ToList();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            filters.Name = textBoxName.Text;
            UpdateStudents();
        }

        private void textBoxSurname_TextChanged(object sender, EventArgs e)
        {
            filters.SurName = textBoxSurname.Text;
            UpdateStudents();
        }

        private void comboBoxSchoolClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if((comboBoxSchoolClass.SelectedItem as SchoolClass).Id == 0)
            {
                filters.SchoolClass = -1;
            }
            else
            {
                filters.SchoolClass = (comboBoxSchoolClass.SelectedItem as SchoolClass).Id;
            }
            UpdateStudents();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            filters.YearOfBirth = (int)numericUpDownYearOfbirth.Value;
            UpdateStudents();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateStudents();
        }

        private void buttonAddStudent_Click(object sender, EventArgs e)
        {
            AddStudentWindow a = new AddStudentWindow();
            DialogResult dialogResult = a.ShowDialog();
            if (dialogResult == DialogResult.Yes)
            {
                
            }
        }
    }
}
