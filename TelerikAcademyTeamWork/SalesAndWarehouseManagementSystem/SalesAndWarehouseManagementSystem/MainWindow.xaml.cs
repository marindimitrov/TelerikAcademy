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
using System.IO;

namespace SalesAndWarehouseManagementSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static Storage companyStorage;
        public static Storage filterStorage;

        private bool StorageIsInitialized()
        {
            if (companyStorage == null)
            {
                MessageBox.Show("No storage is loaded");
                return false;
            }
            return true;
        }

        private void SyncFilterStorage()
        {
            if (companyStorage != null)
            {
                filterStorage = companyStorage.ShallowClone();
            }
        }

        public void SellItems(Merchandise product)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox(string.Format("How much units of {0} would you like to sell?"
                , product.Model));
            if (input != null)
            {
                uint sellAmount;
                if (!uint.TryParse(input, out sellAmount))
                {
                    MessageBox.Show("Incorrect Value");
                    return;
                }
                else
                {
                    if (product.Quantity >= sellAmount)
                    {
                        MessageBoxResult agreeToSell = MessageBox.Show(string.Format("Would you like to sell {0} units of {1} for {2:0.00} bgn.",
                            sellAmount, product.Model, product.Price * sellAmount),
                            "Sell items.",
                            MessageBoxButton.YesNo);
                        if (agreeToSell == MessageBoxResult.Yes)
                        {
                            product.Quantity -= sellAmount;
                            MessageBox.Show(string.Format("{0} units of {1} sold.",
                                sellAmount, product.Model));
                        }
                    }
                    else
                    {
                        MessageBox.Show("Not enough units in store", "Transaction Fail");
                    }
                }
            }
        }

        void LoadStorageFromFile()
        {
            //Retrieving file name
            string fileName;
            Microsoft.Win32.OpenFileDialog selectStorageFileDialogBox = new Microsoft.Win32.OpenFileDialog();
            if (selectStorageFileDialogBox.ShowDialog() != true)//the furst parameter is nullableq thats why we must use == true
            {
                if (false != selectStorageFileDialogBox.ShowDialog())
                {
                    MessageBox.Show(this, "Can't read that file.", "Decoding error", MessageBoxButton.OK,
                        MessageBoxImage.Error, MessageBoxResult.OK, MessageBoxOptions.None);

                }
                return;
            }
            else
            {
                fileName = selectStorageFileDialogBox.FileName;
            }
            //File name retrieved
            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //Initializing company storage.
            companyStorage = StorageFactory.CreateStorage(fileName);
            //company storage initialized
            //Sync wth filter storage
            SyncFilterStorage();
            //Fill the item list with the storage inventory
            FillMerchandiseListBox();
        }

        void FillMerchandiseListBox()
        {
            if (companyStorage != null)
            {
                merchandiseListBox.Items.Clear();
                foreach (Merchandise item in filterStorage.MerchandiseList)
                {
                    merchandiseListBox.Items.Add(new ListBoxItem().Content = item.Model);
                }
            }
            else
            {
                MessageBox.Show("No storage loaded");
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            loadDataButton.Click += loadDataButton_Click;
        }

        void loadDataButton_Click(object sender, RoutedEventArgs e)
        {
            LoadStorageFromFile();
        }

        private void PriceFilter()
        {
            List<Merchandise> FilteredMerch = new List<Merchandise>();
            double minPriceValue;
            if (minimumPriceTextBox.Text == "" ||
                !double.TryParse(minimumPriceTextBox.Text, out minPriceValue))
            {
                minPriceValue = double.MinValue;
            }
            double maxPriceValue;
            if (maximumPriceTextBox.Text == "" ||
                !double.TryParse(maximumPriceTextBox.Text, out maxPriceValue))
            {
                maxPriceValue = double.MaxValue;
            }

            foreach (Merchandise item in filterStorage.MerchandiseList)
            {
                if (item.Price <= maxPriceValue && item.Price >= minPriceValue)
                {
                    FilteredMerch.Add(item);
                }
            }

            filterStorage = new Storage(FilteredMerch);
        }

        private void TypeFilter(string typeString)
        {
            List<Merchandise> FilteredMerch = new List<Merchandise>();
            foreach (Merchandise item in filterStorage.MerchandiseList)
            {
                if (item.GetType().Name == typeString)
                {
                    FilteredMerch.Add(item);
                }
            }
            filterStorage = new Storage(FilteredMerch);
        }

        //Every type should have such a function.
        //This needs to be organized!!!

        private void FilterDesktopComputer()
        {
            List<Merchandise> FilteredMerch = new List<Merchandise>();

            foreach (Merchandise item in filterStorage.MerchandiseList)
            {
                if ((item as DesktopComputer).IsFilterCriteriaMet(this))
                {
                    FilteredMerch.Add(item);
                }
            }

            filterStorage = new Storage(FilteredMerch);
        }
        private void startSearchButton_Click(object sender, RoutedEventArgs e)
        {
            if (StorageIsInitialized())
            {
                PriceFilter();
                if (merchandiceTypeSelectionBox.SelectedItem != null && (merchandiceTypeSelectionBox.SelectedValue as ListBoxItem).Content.ToString() == "Desktop computer")
                {
                    TypeFilter("DesktopComputer");
                    FilterDesktopComputer();
                }
                FillMerchandiseListBox();
            }
        }

        private void searchInputTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Frame_Navigated_1(object sender, NavigationEventArgs e)
        {

        }

        private void RestockProductButton_Click(object sender, RoutedEventArgs e)
        {
            if (merchandiseListBox.SelectedItem == null)
            {
                MessageBox.Show("Select product to restock");
                return;
            }
            else
            {
                string model = merchandiseListBox.SelectedItem.ToString();

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

                        companyStorage.RestockModel(model, restockAmount);

                    }
                }
            }
        }

        private void merchandiseListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void addElementButton_Click(object sender, RoutedEventArgs e)
        {
            AddElement addElementForm = new AddElement();
            addElementForm.Activate();
            addElementForm.Show();
        }

        private void saveDataButton_Click(object sender, RoutedEventArgs e)
        {
            if (companyStorage == null)
            {
                MessageBox.Show("No loaded storage to save");
                return;
            }

            string fileName;
            Microsoft.Win32.SaveFileDialog saveFileDialog = new Microsoft.Win32.SaveFileDialog();
            if (saveFileDialog.ShowDialog() == true)//the furst parameter is nullableq thats why we must use == true
            {
                fileName = saveFileDialog.FileName;
                using (StreamWriter destinationFileWriter = new StreamWriter(fileName))
                {
                    companyStorage.Encode(destinationFileWriter);
                }
                MessageBox.Show("File saved");
                return;
            }
            MessageBox.Show("File NOT saved");
        }

        private void resetMerchendiseListBox_Click(object sender, RoutedEventArgs e)
        {
            if (StorageIsInitialized())
            {
                SyncFilterStorage();
                FillMerchandiseListBox();
            }
        }

        private void HideGroupBoxes()
        {

            ComputingComponentsGroupBox.Visibility = Visibility.Hidden;
        }

        private void merchandiceTypeSelectionBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            HideGroupBoxes();
            if ((merchandiceTypeSelectionBox.SelectedValue as ListBoxItem).Content.ToString() == "Desktop computer")
            {
                ComputingComponentsGroupBox.Visibility = Visibility.Visible;
            }
        }

        private void FilterByModel(string modelSubstring)
        {
            List<Merchandise> filteredMerchandise = new List<Merchandise>();
            //Searching for relevent models in the filtered items
            foreach (Merchandise item in filterStorage.MerchandiseList)
            {
                if (item.Model.IndexOf(modelSubstring) != -1)
                {
                    filteredMerchandise.Add(item);
                }
            }
            filterStorage = new Storage(filteredMerchandise);
            FillMerchandiseListBox();
        }

        private void FilterByDescription(string descriptionSubstring)
        {
            List<Merchandise> filteredMerchandise = new List<Merchandise>();
            //Searching for relevent descriptions in the filtered items
            foreach (Merchandise item in filterStorage.MerchandiseList)
            {
                if (item.Description.IndexOf(descriptionSubstring) != -1)
                {
                    filteredMerchandise.Add(item);
                }
            }
            filterStorage = new Storage(filteredMerchandise);
            FillMerchandiseListBox();
        }

        private void FilterByYear(uint year)
        {
            List<Merchandise> filteredMerchandise = new List<Merchandise>();
            //Searching for relevent descriptions in the filtered items
            foreach (Merchandise item in filterStorage.MerchandiseList)
            {
                if (item.Year == year)
                {
                    filteredMerchandise.Add(item);
                }
            }
            filterStorage = new Storage(filteredMerchandise);
            FillMerchandiseListBox();
        }

        private void filterModelList_Click(object sender, RoutedEventArgs e)
        {
            if (StorageIsInitialized())
            {
                if (searchByModelRadioButton.IsChecked == true)
                {
                    FilterByModel(searchTextBox.Text);
                }
                else if (searchInDescriptionRadioButton.IsChecked == true)
                {
                    FilterByDescription(searchTextBox.Text);
                }
                else if (SearchByYearRadioButton.IsChecked == true)
                {
                    uint year;
                    if (!uint.TryParse(searchTextBox.Text, out year))
                    {
                        MessageBox.Show("Incorrect year format");
                    }
                    else
                    {
                        FilterByYear(year);
                    }
                }
            }

        }

        private void inStockRadioButton_Click(object sender, RoutedEventArgs e)
        {
            if (StorageIsInitialized())
            {
                List<Merchandise> filteredMerchandise = new List<Merchandise>();
                //Searching for items with quantity greater than 0
                foreach (Merchandise item in filterStorage.MerchandiseList)
                {
                    if (item.Quantity > 0)
                    {
                        filteredMerchandise.Add(item);
                    }
                }
                filterStorage = new Storage(filteredMerchandise);
                FillMerchandiseListBox();
            }
        }

        private void inspectSelectedProduct_Click(object sender, RoutedEventArgs e)
        {
            if (merchandiseListBox.SelectedItem != null)
            {
                ViewItem newViewItemForm = new ViewItem(
                    companyStorage.GetMerchandiseModel(merchandiseListBox.SelectedItem.ToString())
                    , this);
                newViewItemForm.Show();
            }
        }

        private void sellSelectedProductButton_Click(object sender, RoutedEventArgs e)
        {
            if (merchandiseListBox.SelectedItem != null)
            {
                SellItems(companyStorage.GetMerchandiseModel(merchandiseListBox.SelectedItem.ToString()));
            }
        }
    }
}
