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
    /// Interaction logic for ViewItem.xaml
    /// </summary>
    public partial class ViewItem : Window
    {
        private Merchandise Product;
        private MainWindow ParentForm;

        private void FillForm(DesktopComputer product)
        {
            CpuFecqalcyTextBlock.Text = product.Cpu.ToString();
            RAMCapacityTextBlock.Text = product.Ram.ToString();
            HDDCapacityTextBlock.Text = product.Hdd.ToString();
            ComputingComponentsGroupBox.Visibility = Visibility.Visible;
        }

        public ViewItem(Merchandise product, MainWindow parent)
        {
            this.Product = product;
            this.ParentForm = parent;
            InitializeComponent();
            modelTextBlock.Text = product.Model;
            manufacturerTextBlock.Text = product.Manufacturer;
            quantityTextBlock.Text = product.Quantity.ToString();
            priceTextBlock.Text = product.Price.ToString();
            yearTextBlock.Text = product.Year.ToString();
            descrioptionTextBlock.Text = product.Description;
            if (product.GetType().Name == "DesktopComputer")
            {
                FillForm(product as DesktopComputer);
            }
            else if (true/*check for other types*/)
            {
                /*what to do in others cases*/
            }
        }

        private void ertockButton_Click(object sender, RoutedEventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox("How many units you want to add ?", "Restock dialog", "1");
            if (input != null)
            {
                uint restockAmount;
                if (!uint.TryParse(input, out restockAmount))
                {
                    MessageBox.Show("Incorrect Value");
                    return;
                }
                else
                {
                    MainWindow.companyStorage.RestockModel(Product.Model,
                        restockAmount);
                }

            }
        }

        private void removeItemButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult dialogResult = MessageBox.Show("Are you sure you want to delete this item?", "Delete file",
                MessageBoxButton.YesNo);
            if (MessageBoxResult.Yes == dialogResult)
            {
                MainWindow.companyStorage.RemoveMerchandiese(Product);
                MessageBox.Show("Item deleated");
                this.Close();
            }
        }

        private void edditItemButton_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void sellButton_Click(object sender, RoutedEventArgs e)
        {
            ParentForm.SellItems(Product);
        }
    }
}