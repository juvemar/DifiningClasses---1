using System;

namespace Mobile
{
    public class Call
    {
        public DateTime dateAndTime;
        public string number;
        public ulong duration;

        public Call(DateTime dateAndTime, string number, ulong duration)
        {
            this.dateAndTime = DateTime.Now;
            this.Number = number;
            this.Duration = duration;
        }

        public DateTime Date
        {
            get
            {
                return this.dateAndTime;
            }
            set
            {
                this.Date = value;
            }
        }

        public string Number
        {
            get
            {
                return this.number;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Number cannot be null or empty!");
                }
                else
                {
                    this.Number = value;
                }
            }
        }
        
        public ulong Duration
        {
            get
            {
                return this.duration;
            }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("Duration of a call cannot be less than 0!");
                }
                else
                {
                    this.Duration = value;
                }
            }
        }
    }
}
