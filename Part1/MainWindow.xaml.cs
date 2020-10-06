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

namespace Part1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string first = firstNameText.Text;
            string last = lastNameText.Text;

            string firstPiglatin = first.Substring(1, 1).ToUpper() + first.Substring(2) + first.Substring(0, 1).ToLower() + "ay";
            string lastPiglatin = last.Substring(1, 1).ToUpper() + last.Substring(2) + last.Substring(0, 1).ToLower() + "ay";

            MessageBox.Show(firstPiglatin + " " + lastPiglatin);
        }
    }
}
