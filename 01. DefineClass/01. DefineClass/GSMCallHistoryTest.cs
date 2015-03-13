using System;
using System.Collections.Generic;
using System.Text;

namespace Mobile
{
    public class GSMCallHistoryTest
    {


        static void Main()
        {
            GSM phone = new GSM("K800", "Sony Ericsson", 300, "Ganio", new Display(3, 5), new Battery("MI250", 150, 300, BatteryType.LiIon));
            Call firstCall = new Call(new DateTime(01, 03, 2014, 3, 30, 45), "0888343434", 123123);
            Call secondCall = new Call(new DateTime(02, 04, 2014, 2, 15, 34), "0888243644", 110243);
            Call thirdCall = new Call(new DateTime(08, 03, 2014, 9, 23, 02), "0888353476", 115032);

            phone.AddCalls(firstCall);
            phone.AddCalls(secondCall);
            Console.WriteLine(phone.CallHistory[0]);
        }
    }
}
