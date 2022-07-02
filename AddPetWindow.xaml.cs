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
    /// Interaction logic for AddPetWindow.xaml
    /// </summary>
    public partial class AddPetWindow : Window
    {
        public AddPetWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// AddPetWindow.Loaded event. It's called after instance have been loaded
        /// to get from database Species entries.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);

            using (var context = new ApplicationDbContext(optionsBuilder.Options))
            {
                SpeciesComboBox.ItemsSource = context.Species.ToList();
            }
        }

        /// <summary>
        /// CancelButton.Click event. It closes AddPetWindow instance.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// ConfirmButton.Click event. Adds new pet entry to database based
        /// on input controls in AddPetWindow instance and closes it.
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
                    PetModel Pet = new PetModel()
                    {
                        Name = NameTextBox.Text,
                        DateOfBirth = DateOfBirthDatePicker.SelectedDate.Value.Date,
                        Id_Species = ((SpeciesModel)SpeciesComboBox.SelectedItem).Id
                    };

                    context.Pets.Add(Pet);
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
