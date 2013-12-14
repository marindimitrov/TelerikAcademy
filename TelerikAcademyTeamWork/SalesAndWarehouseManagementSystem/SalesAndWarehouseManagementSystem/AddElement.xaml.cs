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

namespace SalesAndWarehouseManagementSystem
{
    /// <summary>
    /// Interaction logic for AddElement.xaml
    /// </summary>
    public partial class AddElement : Window
    {
        public void HideGroupBoxes()
        {
            //all group boxes must be hidden
            ComputingComponentsGroupBox.Visibility = Visibility.Hidden;
        }

        public AddElement()
        {
            InitializeComponent();
        }

        private void typeSelectionBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            HideGroupBoxes();
            //Every type should have entry here
            if ((typeSelectionBox.SelectedValue as ListBoxItem).Content.ToString() == "Desktop computer")
            {
                ComputingComponentsGroupBox.Visibility = Visibility.Visible;
            }
        }

        //every type should have such a function !!!
        private void ReadDesktopParameters(string model, string description, string manufacturer, double price, uint year, uint quantity)
        {
            double cpu;
            if (!double.TryParse(cpuFecqalcyTextBox.Text, out cpu) || cpu < 0)
            {
                MessageBox.Show("Incorect cpu value");
                return;
            }

            double ram;
            if (!double.TryParse(RAMCapacityTextBox.Text, out ram) || ram < 0)
            {
                MessageBox.Show("Incorect ram value");
                return;
            }

            double hdd;
            if (!double.TryParse(HDDCapacityTextBox.Text, out hdd) || hdd < 0)
            {
                MessageBox.Show("Incorect hdd value");
                return;
            }

            DesktopComputer newElement = new DesktopComputer(model, description, manufacturer, price, year, quantity, cpu, ram, hdd);
            MainWindow.companyStorage.AddElementInStorage(newElement);
            MessageBox.Show("Element added");
        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            if (MainWindow.companyStorage == null)
            {
                MainWindow.companyStorage = new Storage(new List<Merchandise>());
            }
            string description = (string)descrioptionTextBox.Text.Clone();
            string manufacturer = (string)manufacturerTextBox.Text.Clone();
            string model = (string)modelTextBox.Text.Clone();
            if (MainWindow.companyStorage.CheckForModel(model))
            {
                MessageBox.Show("Merchandise with such model already exists");
                return;
            }

            double price;
            if (!double.TryParse(priceTextBox.Text, out price) || price < 0)
            {
                MessageBox.Show("Incorect price value");
                return;
            }

            uint year;
            if (!uint.TryParse(yearTextBox.Text, out year))
            {
                MessageBox.Show("Incorect year value");
                return;
            }

            uint quantity;
            if (!uint.TryParse(quantityTextBox.Text, out quantity))
            {
                MessageBox.Show("Incorect quantity value");
                return;
            }

            //Every type of merch should have a if statment here similar to "Desktop computer"

            if ((typeSelectionBox.SelectedValue as ListBoxItem).Content.ToString() == "Desktop computer")
            {
                ReadDesktopParameters(model, description, manufacturer, price, year, quantity);

            }
        }
    }
}