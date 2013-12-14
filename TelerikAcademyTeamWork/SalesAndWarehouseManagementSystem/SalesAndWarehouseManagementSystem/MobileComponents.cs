using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesAndWarehouseManagementSystem
{
    class MobileComponents : IFilterable, IDisplayable
    {
        private double cpu;
        private double ramMemory;
        private double displayResolution;
        private bool secondaryCamera;

        public MobileComponents(double cpu, double ramMemory, double displayResolution, bool secondaryCamera)
        {
            Cpu = cpu;
            RamMemory = ramMemory;
            DisplayResolution = displayResolution;
            SecondaryCamera = secondaryCamera;
        }

        public double Cpu
        {
            get { return this.cpu; }
            set { this.cpu = value; }
        }

        public double RamMemory
        {
            get { return this.ramMemory; }
            set { this.ramMemory = value; }
        }

        public double DisplayResolution
        {
            get { return this.displayResolution; }
            set { this.displayResolution = value; }
        }

        public bool SecondaryCamera
        {
            get { return this.secondaryCamera; }
            set { this.secondaryCamera = value; }
        }

        public void Display(ViewItem ViewForm)
        {
            ViewForm.MobileComponentsGroupBox.Visibility = System.Windows.Visibility.Visible;
            ViewForm.CpuTextBlock.Text = cpu.ToString();
            ViewForm.RamMemoryTextBlock.Text = ramMemory.ToString();
            ViewForm.DisplayResolutionTextBlock.Text = displayResolution.ToString();
            ViewForm.SecondaryCameraTextBlock.Text = secondaryCamera.ToString();
        }

        public bool IsFilterCriteriaMet(MainWindow mainWindowForm)
        {
            return true;
        }
    }
}