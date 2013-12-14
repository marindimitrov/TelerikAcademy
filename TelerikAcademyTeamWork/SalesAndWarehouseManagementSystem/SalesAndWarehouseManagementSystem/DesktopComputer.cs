using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesAndWarehouseManagementSystem
{
    public class DesktopComputer : Merchandise
    {
        public DesktopComputer(string model, string description, string manufacturer, double price, uint year, uint quantity, double cpu, double ram, double hdd)
            : base(model, description, manufacturer, price, year, quantity)
        {
            //ComputingComponents DesktopComputerMainParts = new ComputingComponents(cpu, hdd, ram);
            //Cpu = cpu;
            //Ram = ram;
            //Hdd = hdd;
        }

        ComputingComponents DesktopComputerMainParts;

        public double Cpu
        {
            get { return DesktopComputerMainParts.Cpu; }
            set { DesktopComputerMainParts.Cpu = value; }
        }

        public double Ram
        {
            get { return DesktopComputerMainParts.Ram; }
            set { DesktopComputerMainParts.Ram = value; }
        }

        public double Hdd
        {
            get { return DesktopComputerMainParts.Hdd; }
            set { DesktopComputerMainParts.Hdd = value; }
        }

        public override void Display()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override void DisplaySubParts(ViewItem viewItemForm)
        {
            DesktopComputerMainParts.Display(viewItemForm);
        }

        public bool IsFilterCriteriaMet(MainWindow mainWindowForm)
        {

            return DesktopComputerMainParts.IsFilterCriteriaMet(mainWindowForm);

        }

        public override void Encode(StreamWriter writer)
        {
            int lineCount = 0;
            foreach (char symbol in Description)
            {
                if (symbol == '\n')
                {
                    lineCount++;
                }
            }

            writer.WriteLine(lineCount);
            writer.WriteLine(Description);
            writer.WriteLine(Model);
            writer.WriteLine(Manufacturer);
            writer.WriteLine(Price);
            writer.WriteLine(Year);
            writer.WriteLine(Quantity);
            writer.WriteLine(Cpu);
            writer.WriteLine(Ram);
            writer.WriteLine(Hdd);
        }
    }
}