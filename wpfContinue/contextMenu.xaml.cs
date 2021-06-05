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
using System.Windows.Shapes;

namespace wpfContinue
{
    /// <summary>
    /// Interaction logic for contextMenu.xaml
    /// </summary>
    public partial class contextMenu : Window
    {
        public contextMenu()
        {
            InitializeComponent();
        }

      

        private void miBold_Checked(object sender, RoutedEventArgs e)
        {
            myTb.FontWeight = FontWeights.Bold;

        }

        private void miBold_Unchecked(object sender, RoutedEventArgs e)
        {
            myTb.FontWeight = FontWeights.Normal;

        }

        private void miItalic_Checked(object sender, RoutedEventArgs e)
        {
            myTb.FontStyle = FontStyles.Italic;

        }

        private void miItalic_Unchecked(object sender, RoutedEventArgs e)
        {
            myTb.FontStyle = FontStyles.Normal;

        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            myButton.Content = "dont click me anymore";
        }
    }
}
