using Microsoft.EntityFrameworkCore;
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

namespace Szkolny_Dziennik
{
    public partial class Form1 : Form
    {
        StudentsDataBase studentsDataBase;
        Filters filters;
        public Form1()
        {
            studentsDataBase = new StudentsDataBase();
            filters = new Filters() { Name = "", SchoolClass = "", SurName = "", YearOfBirth = -1 };
            InitializeComponent();
            dataGridViewUczniowie.AutoGenerateColumns = false;
            UpdateStudents();   
        }

        private void UpdateStudents()
        {
            List <StudentsView> studentsView;
            var listaW = studentsDataBase.Students
                .Include(x => x.Schoolclass)
                .Select(x => new StudentsView
                {
                    Name = x.Name,
                    SurName = x.SurName,
                    YearOfBirth = x.YearOfBirth,
                    SchoolClass = x.Schoolclass.NameOfSchoolClass  
                }
            );
            studentsView = listaW.ToList();
            addFilters(studentsView);  
        }

        private void addFilters(List<StudentsView> studentsView)
        {
            if (filters.Name != "")
            {

                studentsView = studentsView.Where(x => x.Name.Contains(filters.Name)).ToList();
            }
            dataGridViewUczniowie.DataSource = studentsView;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            filters.Name = textBoxName.Text;
            UpdateStudents();
        }
    }
}
