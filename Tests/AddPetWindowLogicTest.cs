using System;
using System.Threading;
using System.Windows;
using Xunit;

namespace ProjektWPF.Tests
{
    public class AddPetWindowLogicTest
    {
        [Fact]
        public void AddPetIncorrectFormNameTest()
        {
            Thread t = new Thread(() =>
            {
                ProjektWPF.AddPetWindow window = new ProjektWPF.AddPetWindow();
                //window.NameTextBox.Text = "Tester";
                window.DateOfBirthDatePicker.SelectedDate = DateTime.Now;
                window.SpeciesComboBox.SelectedItem = window.SpeciesComboBox.Items[0];

                Assert.Throws<Exception>(() => window.ConfirmButton_Click(null, null));
            });
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }

        [Fact]
        public void AddPetIncorrectFormDateOfBirthTest()
        {
            Thread t = new Thread(() =>
            {
                ProjektWPF.AddPetWindow window = new ProjektWPF.AddPetWindow();
                window.NameTextBox.Text = "Tester";
                //window.DateOfBirthDatePicker.SelectedDate = DateTime.Now;
                window.SpeciesComboBox.SelectedItem = window.SpeciesComboBox.Items[0];

                Assert.Throws<Exception>(() => window.ConfirmButton_Click(null, null));
            });
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }

        [Fact]
        public void AddPetIncorrectFormSpeciesTest()
        {
            Thread t = new Thread(() =>
            {
                ProjektWPF.AddPetWindow window = new ProjektWPF.AddPetWindow();
                window.NameTextBox.Text = "Tester";
                window.DateOfBirthDatePicker.SelectedDate = DateTime.Now;
                //window.SpeciesComboBox.SelectedItem = window.SpeciesComboBox.Items[0];

                Assert.Throws<Exception>(() => window.ConfirmButton_Click(null, null));
            });
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }
    }
}