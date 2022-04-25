using System.Windows;
using System.Windows.Controls;

namespace Bindowanie 
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBlock.Text = "Value: " + textBox.Text;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}