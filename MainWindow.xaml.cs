using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
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

namespace ProjektWPF
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

        /// <summary>
        /// AddAppointmentButton.Click event. Creates new AddAppointmentWindow instance
        /// and shows it.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddAppointmentButton_Click(object sender, RoutedEventArgs e)
        {
            Window win = new AddAppointmentWindow();
            win.Show();
        }

        /// <summary>
        /// AddPetButton.Click event. Creates new AddPetWindow instance
        /// and shows it.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddPetButton_Click(object sender, RoutedEventArgs e)
        {
            Window win = new AddPetWindow();
            win.Show();
        }
    }
}
