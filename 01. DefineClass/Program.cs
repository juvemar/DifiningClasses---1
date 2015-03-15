using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile
{
    public class Program
    {
        static void Main()
        {
            GSMCallHistoryTest tester = new GSMCallHistoryTest();
            tester.AddingCalls();
            tester.PrintCallHistory(GSMCallHistoryTest.phone);
            tester.CalculateTotalPrice(GSMCallHistoryTest.phone);
            tester.CalculateTotalPriceAfterRemoval(GSMCallHistoryTest.phone);
            tester.ClearHistory(GSMCallHistoryTest.phone);

            GSMTest mobiles = new GSMTest();
            Console.WriteLine("\nPhones registry:");
            mobiles.DisplayGSMs();

            mobiles.DisplayIPhone();
        }
    }
}
