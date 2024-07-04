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
a
namespace PetsApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Pet> myPets = new List<Pet>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAddPet_Click(object sender, RoutedEventArgs e)
        {
            string name = txtName.Text;
            int age = int.Parse(txtAge.Text);
            string species = (string)((ListBoxItem)lstSpecies.SelectedItem).Content;
            
            Pet newPet = new Pet(name, age, species);
            myPets.Add(newPet);
            lstPets.Items.Add(new ListBoxItem{Content = newPet.ToString()});

            txtName.Clear();
            txtAge.Clear();

        }
    }

    public class Pet
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Species { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, Species: {Species}, Age: {Age}";
        }

        public Pet(string name, int age, string species)
        {
            Name = name;
            Age = age;
            Species = species;
        }
    }
}
