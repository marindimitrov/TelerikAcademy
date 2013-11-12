using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobilePhoneDeviceClass;


namespace GSMCallHistoryTest
{
    class GSMCallHistoryTest
    {
        static void Main()
        {
            GSM myGSM = new GSM("Lumia 720", "Nokia", 500, "Shaban");
            Call firstCall = new Call(120);
            myGSM.CallHistory.Add(firstCall);
            Call secondCall = new Call(60);
            myGSM.CallHistory.Add(secondCall);
            Call thirdCall = new Call(345);
            myGSM.CallHistory.Add(thirdCall);
            Call fourthCall = new Call(12);
            myGSM.CallHistory.Add(fourthCall);
            Call fifthCall = new Call(45);
            myGSM.CallHistory.Add(fifthCall);

            decimal totalCallsPrice = myGSM.CalculateTotalPrice(myGSM.CallHistory);
            Console.WriteLine(totalCallsPrice);
        }
    }
}
