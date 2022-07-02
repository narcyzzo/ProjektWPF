using Microsoft.EntityFrameworkCore;
using ProjektWPF.Models;
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
using System.Windows.Shapes;

namespace ProjektWPF
{
    /// <summary>
    /// Interaction logic for AddAppointmentWindow.xaml
    /// </summary>
    public partial class AddAppointmentWindow : Window
    {
        public AddAppointmentWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// AddAppointmentWindow.Loaded event. It's called after instance have been loaded
        /// to get from database Pets and Doctors entries.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);

            using (var context = new ApplicationDbContext(optionsBuilder.Options))
            {
                PetComboBox.ItemsSource = context.Pets.ToList();
                DoctorComboBox.ItemsSource = context.Doctors.ToList();
            }
        }

        /// <summary>
        /// CancelButton.Click event. Closes AddAppointmentWindow instance.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// ConfirmButton.Click event. Adds new appointment entry to database based
        /// on input controls in AddAppointmentWindow instance and closes it.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ConfirmButton_Click(object sender, RoutedEventArgs e)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);

            try
            {
                using (var context = new ApplicationDbContext(optionsBuilder.Options))
                {
                    AppointmentModel appointment = new AppointmentModel()
                    {
                        DateOfAppointment = DateOfAppointmentDatePicker.SelectedDate.Value.Date,
                        Price = decimal.Parse(PriceTextBox.Text),
                        Id_Pet = ((PetModel)PetComboBox.SelectedItem).Id,
                        Id_Doctor = ((DoctorModel)DoctorComboBox.SelectedItem).Id
                    };

                    context.Appointments.Add(appointment);
                    context.SaveChanges();
                    this.Close();
                }
            }
            catch (Exception exc)
            {
                System.Windows.MessageBox.Show(exc.Message, "ERROR");
            }
        }       
    }
}
