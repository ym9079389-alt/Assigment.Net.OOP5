using System;
using System.Collections.Generic;
using System.Text;

namespace Assigment.Net.OOP5
{
    internal class DeliveryReport
    {
        public void PrintShipment(ITrackable shipment)
        {
            Console.WriteLine(shipment.GetTrackingStatus());
        }
    }
}
