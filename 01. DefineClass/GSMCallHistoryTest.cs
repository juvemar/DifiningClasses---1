using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Mobile
{
    public class GSMCallHistoryTest
    {
        private const decimal pricePerMin = 0.37m;

        public static GSM phone = new GSM("K800", "Sony Ericsson", 300, "Ganio", new Display(3, 5),
                                new Battery("MI250", 150, 300, BatteryType.LiIon));
        private static Call firstCall = new Call(new DateTime(2014, 3, 1, 3, 30, 45), "0888343434", 123123);
        private static Call secondCall = new Call(new DateTime(2014, 4, 2, 2, 15, 34), "0888243644", 110243);
        private static Call thirdCall = new Call(new DateTime(2014, 3, 8, 9, 23, 2), "0888353476", 115032);

        public void AddingCalls()
        {
            phone.AddCalls(firstCall);
            phone.AddCalls(secondCall);
            phone.AddCalls(thirdCall);
        }

        public void PrintCallHistory(GSM phone)
        {
            foreach (var item in phone.CallHistory)
            {
                DateTime currentDate = item.dateAndTime;
                string currentNumber = item.number;
                ulong currentDuration = item.duration;

                Console.WriteLine("Date: {0}\nPhone number: {1}\nCall duration: {2} sec", currentDate, currentNumber, currentDuration);
                Console.WriteLine();
            }
        }

        public void CalculateTotalPrice(GSM phone)
        {
            Console.WriteLine("The total price of the calls is {0} cents.", phone.TotalCallsPrice(pricePerMin));
        }

        public void CalculateTotalPriceAfterRemoval(GSM phone)
        {
            DeleteLongestCall(phone);
            Console.WriteLine("The total price of the calls after the erasure is {0} cents.", phone.TotalCallsPrice(pricePerMin));
        }

        private void DeleteLongestCall(GSM phone)
        {
            decimal max = phone.CallHistory[0].duration;
            int toBeDeleted = 0;

            for (int i = 1; i < phone.CallHistory.Count; i++)
            {
                if (phone.CallHistory[i].duration > max)
                {
                    toBeDeleted = i;
                }
            }

            phone.CallHistory.RemoveAt(toBeDeleted);
        }

        public void ClearHistory(GSM phone)
        {
            phone.CallHistory.Clear();
            PrintCallHistory(phone);
            Console.WriteLine("Calls deleted!");
        }
    }
}
