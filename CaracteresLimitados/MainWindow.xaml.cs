using System;
using System.Collections.Generic;
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

namespace CaracteresLimitados
{
    public partial class MainWindow : Window
    {
        int numeroCaracteres = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextoTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            numeroCaracteres = TextoTextBox.Text.Length;
            if (numeroCaracteres > 139) TextoTextBox.IsEnabled = false;
            CaracteresTextBlock.Text = numeroCaracteres + "/140";
        }
    }
}
