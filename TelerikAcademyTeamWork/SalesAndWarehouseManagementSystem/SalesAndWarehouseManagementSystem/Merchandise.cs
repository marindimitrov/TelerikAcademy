using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SalesAndWarehouseManagementSystem
{
    public abstract class Merchandise : IEncodable
    {
        private string description;
        private string model;
        private string manufacturer;
        private double price;
        private uint year;
        private uint quantity;

        public Merchandise(string model, string description, string manufacturer, double price, uint year, uint quantity)
        {
            Model = model;
            Description = description;
            Manufacturer = manufacturer;
            Price = price;
            Year = year;
            Quantity = quantity;
        }

        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public string Manufacturer
        {
            get { return this.manufacturer; }
            set { this.manufacturer = value; }
        }

        public double Price
        {
            get { return this.price; }
            set { this.price = value; }
        }

        public uint Year
        {
            get { return this.year; }
            set { this.year = value; }
        }

        public uint Quantity
        {
            get { return this.quantity; }
            set { this.quantity = value; }
        }

        public bool Sell(string customerName, uint quantity)
        {
            throw new NotImplementedException();
        }

        abstract public void Display();

        abstract public void DisplaySubParts(ViewItem viewItemForm);

        abstract public void Encode(StreamWriter writer);
    }
}