using System;
using System.Collections.Generic;
using System.Text;

namespace Mobile
{
    public class GSM
    {
        private const double pricePerMin = 0.5;

        private static GSM IPhone4S;

        private string gsmModel;
        private string gsmManufacturer;
        private int gsmPrice;
        private string gsmOwner;
        private Battery gsmBattery;
        private Display gsmDisplay;


        public GSM(string model, string manufactuter)
        {
            this.Model = model;
            this.Manufacturer = manufactuter;
        }
        public GSM(string model, string manufactuter, int price, string owner)
            : this(model, manufactuter)
        {
            this.Price = price;
            this.Owner = owner;
        }

        public GSM(string model, string manufactuter, int price, string owner, Display display, Battery battery)
            : this(model, manufactuter, price, owner)
        {
            this.gsmBattery = battery;
            this.gsmDisplay = display;
        }

        public override string ToString() //Problem 4
        {
            StringBuilder info = new StringBuilder();
            info.AppendLine("Information about the phone:");
            info.AppendLine("Manufacturer - " + this.gsmManufacturer);
            info.AppendLine("Model - " + this.gsmModel);
            info.AppendLine("Price - " + this.gsmPrice);
            info.Append("Owner - " + this.gsmOwner);
            return info.ToString();
        }

        public string Model
        {
            get
            {
                return this.gsmModel;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Model name cannot be empty or null!");
                }
                else
                {
                    this.Model = value;
                }
            }
        }

        public string Manufacturer
        {
            get
            {
                return this.gsmManufacturer;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Manufacturer name cannot be empty or null!");
                }
                else
                {
                    this.gsmManufacturer = value;
                }
            }
        }

        public string Owner
        {
            get
            {
                return this.gsmOwner;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Owner must have a name!");
                }
                else
                {
                    this.gsmOwner = value;
                }
            }
        }

        public int Price
        {
            get
            {
                return this.gsmPrice;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArithmeticException("Price cannot be a negative number!");
                }
                else
                {
                    this.gsmPrice = value;
                }
            }
        }

        public static GSM IPhone
        {
            get
            {
                return new GSM("4S", "Apple");
            }
        }

        public List<Call> CallHistory
        {
            get
            {
                return this.CallHistory;
            }
        }

        public void AddCalls(DateTime dateAndTime, string number, ulong duration)
        {
            CallHistory.Add(new Call(dateAndTime, number, duration));
        }

        public void DeleteCalls(Call deletedCall)
        {
            Console.WriteLine("Enter date and time for the call you want to be deleted: ");
            DateTime chooseCall = DateTime.Parse(Console.ReadLine());
            for (int i = 0; i < CallHistory.Count; i++)
            {
                if (CallHistory[i].Date == chooseCall)
                {
                    CallHistory[i] = null;
                    chooseCall = DateTime.Now;
                    continue;
                }
                if (chooseCall == DateTime.Now)
                {
                    CallHistory[i - 1] = CallHistory[i];
                }
            }
            CallHistory.RemoveAt(CallHistory.Count - 1);
        }

        public void ClearCallHistory()
        {
            CallHistory.Clear();
        }

        public double TotalCallsPrice()
        {
            double totalPrice = 0;
            for (int i = 0; i < CallHistory.Count; i++)
            {
                totalPrice += pricePerMin * (CallHistory[i].Duration / 60);
            }

            return totalPrice;
        }
    }
}
