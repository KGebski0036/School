using BazaDanych.Repository;
using Quizy.Zak�adki;

namespace Quizy
{
    public partial class Quiz : Form
    {
        private ListRepository Repository;
        public Quiz()
        {
            InitializeComponent();
            Repository = new ListRepository();
            ucListaPytan1.Repository = Repository;
            ucListaPytan1.RefreshData();
        }
       
    }
}