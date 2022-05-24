using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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
using ThreeLayer.Database.DAL;
using DTO.Model;
using System.Text.Json;

namespace WpfGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private PersonContext context = new PersonContext();  
        public MainWindow()
        {
            InitializeComponent();


            

            PersonBox.ItemsSource = context.Persons.Local;

            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            HttpClient client = new HttpClient();
            Task<string> task = client.GetStringAsync("https://localhost:44332/api/Person");
            string results = task.Result;
            List<Person> persons = JsonSerializer.Deserialize<List<Person>>(results);
            GruppeBox.ItemsSource = persons;
        }
    }
}
