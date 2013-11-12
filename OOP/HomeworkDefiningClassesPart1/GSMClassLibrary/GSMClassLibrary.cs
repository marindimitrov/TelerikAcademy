using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneDeviceClass
{
    public enum BateryType
    {
        LiIon, NiMH, NiCd, LiPoly
    }
    public class GSM
    {
        // Fields
        private string model;
        private string manufacturer;
        private decimal price;
        private string owner;
        private Battery battery = new Battery("Toshiba");
        private Display display = new Display(5, 65535);
        private static GSM iPhone = new GSM("iPhone4S", "Apple");
        private List<Call> callHistory = new List<Call>();
        private const decimal pricePerMinute = 0.37m;

        // Constructors
        public GSM(string model, string manufacturer)
        {
            this.model = model;
            this.manufacturer = manufacturer;
        }
        public GSM(string model, string manufacturer, decimal price, string owner)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
            this.owner = owner;
        }

        // Properties
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
        public decimal Price
        {
            get { return this.price; }
            set { this.price = value; }
        }
        public string Owner
        {
            get { return this.owner; }
            set { this.owner = value; }
        }
        public Battery Battery
        {
            get { return this.battery; }
            set { this.battery = value; }
        }
        public Display Display
        {
            get { return this.display; }
            set { this.display = value; }
        }
        public static GSM IPhone
        {
            get { return iPhone; }
        }
        public List<Call> CallHistory
        {
            get { return this.callHistory; }
        }

        //Override ToString()
        public override string ToString()
        {
            StringBuilder info = new StringBuilder();
            info.Append("\nGSM model: " + model);
            info.Append("\nGSM manufacturer: " + manufacturer);
            info.Append("\nGSM price: " + price);
            info.Append("\nGSM owner: " + owner);
            info.Append("\nGSM battery : " + battery);
            info.Append("\nGSM model: " + display);
            return info.ToString();
        }

        // Methods
        public void AddCall(Call call)
        {
            callHistory.Add(call);
        }
        public void DeleteCall(Call call)
        {
            callHistory.Remove(call);
        }
        public void ClearHistory()
        {
            callHistory.Clear();
        }
        public decimal CalculateTotalPrice(List<Call> callHistory)
        {
            int totalDurationInSeconds = 0;
            foreach (var item in callHistory)
            {
                totalDurationInSeconds += item.Duration;
            }
            decimal totalPrice = (totalDurationInSeconds / 60) * pricePerMinute;
            return totalPrice;
        }
    }
    public class Battery
    {
        // Fields
        private string model;
        private int hoursIdle;
        private int hoursTalk;
        private BateryType bateryType;

        // Constructors
        public Battery(string model)
        {
            this.model = model;
        }

        public Battery(string model, int hoursIdle, int hoursTalk, BateryType bateryType)
        {
            this.model = model;
            this.hoursIdle = hoursIdle;
            this.hoursTalk = hoursTalk;
        }

        // Properties
        public string Model
        {
            get { return this.model; }
        }

        public int HoursIdle
        {
            get { return this.hoursIdle; }
        }

        public int HoursTalk
        {
            get { return this.hoursTalk; }
        }
        public BateryType BateryType
        {
            get { return this.bateryType; }
            set { this.bateryType = value; }
        }
    }
    public class Display
    {
        private int size;
        private int numberOfColours;

        public Display(int size, int numberOfColours)
        {
            this.size = size;
            this.numberOfColours = numberOfColours;
        }

        public int Size
        {
            get { return this.size; }
            set { this.size = value; }
        }

        public int NumberOfColours
        {
            get { return this.numberOfColours; }
            set
            {
                if (value > 1 && value < 65535)
                {
                    this.numberOfColours = value;
                }
                else
                {
                    throw new ArgumentException("Colors must be between 1 and 65535");
                }
            }
        }
    }
    public class Call
    {
        private DateTime dateTime;
        private int dialedPhoneNumber;
        private int duration; 

        public Call(int duration)
        {
            this.duration = duration;
        }
        public Call(DateTime dateTime, int dialedPhoneNumber, int duration)
        {
            this.dateTime = dateTime;
            this.dialedPhoneNumber = dialedPhoneNumber;
            this.duration = duration;
        }
        public DateTime DateTime
        {
            get { return this.dateTime; }
        }
        public int DialedPhoneNumber
        {
            get { return this.dialedPhoneNumber; }
        }
        public int Duration
        {
            get { return this.duration; }
        }
    }
}