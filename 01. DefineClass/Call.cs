using System;

namespace Mobile
{
    public class Call
    {
        public DateTime dateAndTime;
        public string number;
        public ulong duration;

        public Call(DateTime dateTime, string number, ulong duration)
        {
            this.dateAndTime = dateTime;
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
                this.dateAndTime = value;
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
                    this.number = value;
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
                    this.duration = value;
                }
            }
        }
    }
}
