﻿using System;
using System.Collections.Generic;

namespace Mobile
{
    public enum Owners
    {
        Vanio, Joro, Tosho, Pesho, Sasho, Tisho
    };
    public class GSMTest
    {
        public void DisplayGSMs()
        {
            List<GSM> phone = new List<GSM>();
            for (int i = 0; i < 6; i++)
            {
                Owners possessor = (Owners)i;
                phone.Add(new GSM("C35", "Siemens", 100 + i, possessor.ToString()));
            }
            foreach (var gsm in phone)
            {
                Console.WriteLine(gsm);
            }
        }

        public void DisplayIPhone()
        {
            Console.WriteLine(GSM.IPhone);
        }
    }
}
