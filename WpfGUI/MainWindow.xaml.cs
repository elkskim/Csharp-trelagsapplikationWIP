using System;
using System.Collections.Generic;
using System.Data.Entity;
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
using ThreeLayer.Database.DAL;

namespace WpfGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            PersonContext context = new PersonContext();

            context.Persons.Load();
            context.Groups.Load();

            PersonBox.ItemsSource = context.Persons.Local;
            GruppeBox.ItemsSource = context.Groups.Local;
        }
    }
}
