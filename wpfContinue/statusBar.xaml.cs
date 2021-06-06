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
    /// Interaction logic for statusBar.xaml
    /// </summary>
    public partial class statusBar : Window
    {
        public statusBar()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (myPb.Value >= 100) 
            {
                sbItem.Content = "Done";
            }

            else 
                myPb.Value += 10;
            
        }
    }
}
