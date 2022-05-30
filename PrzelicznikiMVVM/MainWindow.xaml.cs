using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PrzelicznikiMVVM
{
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public string InputValue { get; set; }
        private string _outputValue;

        public event PropertyChangedEventHandler PropertyChanged;

        public string OutputValue 
        {
            get => _outputValue;
            set
            {
                _outputValue = value;
                OnPropertyChenged(nameof(OutputValue));
            }
        }

        private void OnPropertyChenged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            OutputValue = InputValue;

        }
    }
}
