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

namespace QuadrantQuestion
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

        private void btnRun_Click(object sender, RoutedEventArgs e)
        {

            int digits = Convert.ToInt32(txtEntry.Text.Substring(0, txtEntry.Text.IndexOf("\r")));
            int second = Convert.ToInt32(txtEntry.Text.Substring(txtEntry.Text.IndexOf("\n")- 1));

            if (digits > 0)
            {
                if (second > 0)
                {
                    lblGrid.Content = "1";
                }
                else
                {
                    lblGrid.Content = "2";
                }
            }
            if (digits < 0)
            {
                if (second < 0)
                {
                    lblGrid.Content = "3";
                }
                else
                {
                    lblGrid.Content = "4";
                }
            }
            
        }
    }
}
