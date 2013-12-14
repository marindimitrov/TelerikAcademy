using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesAndWarehouseManagementSystem
{
    class ComputingComponents : IFilterable, IDisplayable
    {
        private double cpu;
        private double hdd;
        private double ram;

        public ComputingComponents(double cpuParam, double hddParam, double ramParam)
        {
            Cpu = cpuParam;
            Hdd = hddParam;
            Ram = ramParam;
        }

        public double Cpu
        {
            get { return cpu; }
            set { cpu = value; }
        }

        public double Hdd
        {
            get { return hdd; }
            set { hdd = value; }
        }

        public double Ram
        {
            get { return ram; }
            set { ram = value; }
        }

        public void Display(ViewItem ViewForm)
        {
            ViewForm.ComputingComponentsGroupBox.Visibility = System.Windows.Visibility.Visible;
            ViewForm.CpuFecqalcyTextBlock.Text = cpu.ToString();
            ViewForm.RAMCapacityTextBlock.Text = ram.ToString();
            ViewForm.HDDCapacityTextBlock.Text = hdd.ToString();
        }

        public bool IsFilterCriteriaMet(MainWindow mainWindowForm)
        {
            //filtering by cpu
            double cpu;
            if (mainWindowForm.minimalCpuFrequencyTextBox.Text == "" ||
                !double.TryParse(mainWindowForm.minimalCpuFrequencyTextBox.Text, out cpu))
            {
                cpu = double.MinValue;
            }
            if (this.Cpu < cpu)
            {
                return false;
            }

            //filter by hdd
            double hdd;

            if (mainWindowForm.minimalHDDCapacityTextBox.Text == "" ||
                !double.TryParse(mainWindowForm.minimalHDDCapacityTextBox.Text, out hdd))
            {
                hdd = double.MinValue;
            }

            if (this.Hdd < hdd)
            {
                return false;
            }

            //filter by ram
            double ram;
            if (mainWindowForm.minimalRAMCapacityTextBox.Text == "" ||
                !double.TryParse(mainWindowForm.minimalRAMCapacityTextBox.Text, out ram))
            {
                ram = double.MinValue;
            }

            if (this.Ram < ram)
            {
                return false;
            }

            //if all filters passed 
            return true;
        }
    }
}