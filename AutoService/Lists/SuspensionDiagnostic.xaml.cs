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

namespace AutoService.Lists
{
    /// <summary>
    /// Логика взаимодействия для SuspensionDiagnostic.xaml
    /// </summary>
    public partial class SuspensionDiagnostic : Window
    {
        public SuspensionDiagnostic()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow mainWindow = new MainWindow();
            mainWindow.ShowDialog();
            this.Close();
        }

        private void btnForw_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            User user = new User();
            user.ShowDialog();
            this.Close();
        }
    }
}
