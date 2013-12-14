using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesAndWarehouseManagementSystem
{
    class MobilePhone : Merchandise
    {
        public MobilePhone(string model, string description, string manufacturer, double price, uint year, uint quantity)
            : base(model, description, manufacturer, price, year, quantity)
        {

        }

        MobileComponents MobilePhoneMainParts;

        public double Cpu
        {
            get { return MobilePhoneMainParts.Cpu; }
            set { MobilePhoneMainParts.Cpu = value; }
        }

        public double RamMemory
        {
            get { return MobilePhoneMainParts.RamMemory; }
            set { MobilePhoneMainParts.RamMemory = value; }
        }

        public double DisplayResolution
        {
            get { return MobilePhoneMainParts.DisplayResolution; }
            set { MobilePhoneMainParts.DisplayResolution = value; }
        }

        public bool SecondaryCamera
        {
            get { return MobilePhoneMainParts.SecondaryCamera; }
            set { MobilePhoneMainParts.SecondaryCamera = value; }
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
            MobilePhoneMainParts.Display(viewItemForm);
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
            writer.WriteLine(RamMemory);
            writer.WriteLine(DisplayResolution);
            writer.WriteLine(SecondaryCamera);
        }
    }
}