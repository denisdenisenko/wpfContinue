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
    /// Interaction logic for toolbox.xaml
    /// </summary>
    public partial class toolbox : Window
    {
        public toolbox()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            myTxtBox.Text = "";
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            ComboBoxItem cbItem = (ComboBoxItem)cb.SelectedItem;
            string newCboxValue = (string)cbItem.Content;

            int temp;
            if (Int32.TryParse(newCboxValue, out temp))
            
            {
                if (myTxtBox != null) 
                {
                    myTxtBox.FontSize = temp;
                }
            }
        }
    }
}
