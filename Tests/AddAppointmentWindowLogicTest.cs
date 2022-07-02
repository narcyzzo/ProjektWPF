using System;
using System.Threading;
using System.Windows;
using Xunit;

namespace ProjektWPF.Tests
{
    public class AddAppointmentWindowLogicTest
    {
        [Fact]
        public void AddAppointmentIncorrectFormDateOfAppointmentTest()
        {
            Thread t = new Thread(() =>
            {
                ProjektWPF.AddAppointmentWindow window = new ProjektWPF.AddAppointmentWindow();
                //window.DateOfAppointmentDatePicker.SelectedDate = DateTime.Today;
                window.PriceTextBox.Text = 200.ToString();
                window.PetComboBox.SelectedItem = window.PetComboBox.Items[0];
                window.DoctorComboBox.SelectedItem = window.DoctorComboBox.Items[0];

                Assert.Throws<Exception>(() => window.ConfirmButton_Click(null, null));
            });
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }

        [Fact]
        public void AddAppointmentIncorrectFormPriceTest()
        {
            Thread t = new Thread(() =>
            {
                ProjektWPF.AddAppointmentWindow window = new ProjektWPF.AddAppointmentWindow();
                window.DateOfAppointmentDatePicker.SelectedDate = DateTime.Today;
                //window.PriceTextBox.Text = 200.ToString();
                window.PetComboBox.SelectedItem = window.PetComboBox.Items[0];
                window.DoctorComboBox.SelectedItem = window.DoctorComboBox.Items[0];

                Assert.Throws<Exception>(() => window.ConfirmButton_Click(null, null));
            });
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }

        [Fact]
        public void AddAppointmentIncorrectFormPetTest()
        {
            Thread t = new Thread(() =>
            {
                ProjektWPF.AddAppointmentWindow window = new ProjektWPF.AddAppointmentWindow();
                window.DateOfAppointmentDatePicker.SelectedDate = DateTime.Today;
                window.PriceTextBox.Text = 200.ToString();
                //window.PetComboBox.SelectedItem = window.PetComboBox.Items[0];
                window.DoctorComboBox.SelectedItem = window.DoctorComboBox.Items[0];

                Assert.Throws<Exception>(() => window.ConfirmButton_Click(null, null));
            });
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }

        [Fact]
        public void AddAppointmentIncorrectFormDoctorTest()
        {
            Thread t = new Thread(() =>
            {
                ProjektWPF.AddAppointmentWindow window = new ProjektWPF.AddAppointmentWindow();
                window.DateOfAppointmentDatePicker.SelectedDate = DateTime.Today;
                window.PriceTextBox.Text = 200.ToString();
                window.PetComboBox.SelectedItem = window.PetComboBox.Items[0];
                //window.DoctorComboBox.SelectedItem = window.DoctorComboBox.Items[0];

                Assert.Throws<Exception>(() => window.ConfirmButton_Click(null, null));
            });
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }
    }
}
