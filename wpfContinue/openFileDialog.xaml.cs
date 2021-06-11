using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.Win32;
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
    /// Interaction logic for openFileDialog.xaml
    /// </summary>
    public partial class openFileDialog : Window
    {
        public openFileDialog()
        {
            InitializeComponent();
        }

        private void openFileButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            //openFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFiles);

            //openFile.InitialDirectory = @"C:\";

            openFile.InitialDirectory = 
                System.IO.Path.GetFullPath(Environment.CurrentDirectory + @"\..\..\..\..");

            openFile.Filter = "Text files (*.txt)| *.txt|All file (*.*)|*.*";

            if (openFile.ShowDialog() == true) 
            {
                myTextBox.Text = File.ReadAllText(openFile.FileName);
            }
        }
    }
}
