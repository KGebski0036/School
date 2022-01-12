using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pierwsze_okienko
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int c = random.Next(0, 10);
            switch (c)
            {
                case 0:
                    button.Text = "Serio przestań =_=";
                    break;
                case 1:
                    button.Text = "To nie jest śmieszne";
                    break;
                case 2:
                    button.Text = "Zaraz stanie się coś strasznego";
                    MessageBox.Show("Czy na pewno chces usunąć folder System32?", "Błąd wygenerowany pomyślnie",MessageBoxButtons.OK);
                    break;
                case 3:
                    button.Text = "Przestań";
                    break;
                case 4:
                    button.Text = "No nie jest przyscisk do klikania";
                    break;
                case 5:
                    button.Text = "Jesteś głupi ?!?";
                    break;
                case 6:
                    button.Text = "STOP!!!111!";
                    break;
                case 7:
                    button.Text = "Matka Cię nie wychowała?";
                    break;
                case 8:
                    button.Text = "Jak bym miał ręce to już byś oberwał";
                    break;
                case 9:
                    button.Text = "Doigrałeś się wiem gdzie mieszkasz ";
                    break;
                case 10:
                    button.Text = " ";
                    break;
            }
            
        }
    }
}
