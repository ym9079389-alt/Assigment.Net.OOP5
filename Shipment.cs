using System;
using System.Collections.Generic;
using System.Text;

namespace Assigment.Net.OOP5
{ 

    public abstract partial class Shipment
    {
        //private string trackingCode = string.Empty;
        private string description = string.Empty;

        public string TrackingCode { get; init; }
        private decimal weight;
        private decimal deliveryFee;
        public DeliveryAddress Destination { get; set; }
        public abstract decimal EstimatedCost { get; }
        public static int TotalShipmentsCreated;


        public string Description
        {
            get { return description; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    description = value;
                }
            }
        }

        public decimal Weight
        {
            get { return weight; }
            set
            {
                if (value > 0)
                {
                    weight = value;
                }
            }
        }

        public virtual decimal DeliveryFee
        {
            get { return deliveryFee; }
            private set
            {
                if (value >= 0)
                {
                    deliveryFee = value;
                }
            }
        }



        public Shipment(string trackingCode)
        {
            TrackingCode = trackingCode;
            Description = "Unknown";
            Weight = 1m;
            DeliveryFee = 50m;
            Destination = new DeliveryAddress("Cairo", "Unknown Street", 0);
        }

        public Shipment( string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination) 
        {
            TrackingCode = trackingCode;
            Description = description;
            Weight = weight;
            DeliveryFee = deliveryFee;
            Destination = destination;

            TotalShipmentsCreated++;
        }
        static Shipment()
        {
            TotalShipmentsCreated = 0;
            Console.WriteLine("Shipment System Initialized");
        }

        public void UpdateDeliveryFee(decimal newFee)
        {
            if (newFee >= 0)
            {
                DeliveryFee = newFee;
            }
        }

        public abstract void PrintShipment();

        public Shipment CopyShipment()
        {
            return (Shipment) this.MemberwiseClone();
        }

        public Shipment ShallowCopy()
        {
            return (Shipment) this.MemberwiseClone();
        }
        public static int GetTotalShipmentsCreated()
        {
            return TotalShipmentsCreated;
        }
        public Shipment DeepCopy()
        {
            Shipment copy = (Shipment)this.MemberwiseClone();
            copy.Destination = new DeliveryAddress(this.Destination.City, this.Destination.Street, this.Destination.BuildingNumber);
            return copy;
        }

        partial void OnTrackingStatusChanged(string newStatus)
        {
            Console.WriteLine($"Tracking status changed to: {newStatus}");
        }

    }








    public class StandardShipment : Shipment, ITrackable, IInsurable
    {
        public StandardShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination)
            : base(trackingCode, description, weight, deliveryFee, destination)
        {
        }
        public override decimal EstimatedCost
        {
            get
            {
                return DeliveryFee + (Weight * 5);
            }
        }
        public override void PrintShipment()
        {
            Console.WriteLine($"Tracking Code : {TrackingCode}");
            Console.WriteLine($"Description   : {Description}");
            Console.WriteLine($"Weight        : {Weight} kg");
            Console.WriteLine($"Delivery Fee  : {DeliveryFee:C}");
            Console.WriteLine($"Destination   : {Destination.GetFullAddress()}");
            Console.WriteLine($"Estimated Cost: {EstimatedCost} EG");
        }

        public string GetTrackingStatus()
        {
            return $"Shipment {TrackingCode} is Ready.";
        }
        public decimal CalculateInsurance()
        {
            return (5m / 100m) * EstimatedCost;
        }
    }



    public class ExpressShipment : Shipment, ITrackable, IInsurable
    {
        private decimal extraFee;
        public decimal ExtraFee
        {
            get
            {
                return extraFee;
            }
            set
            {
                if (value >= 0)
                {
                    extraFee = value;
                }
            }
        }
        public override decimal EstimatedCost
        {
            get
            {
                return DeliveryFee + (Weight * 5) + ExtraFee;
            }
        }
        public ExpressShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination, decimal extrafee)
            : base(trackingCode, description, weight, deliveryFee, destination)
        {
            ExtraFee = extraFee;
        }
        public override void PrintShipment()
        {
            Console.WriteLine($"Tracking Code : {TrackingCode}");
            Console.WriteLine($"Description   : {Description}");
            Console.WriteLine($"Weight        : {Weight} kg");
            Console.WriteLine($"Delivery Fee  : {DeliveryFee:C}");
            Console.WriteLine($"Destination   : {Destination.GetFullAddress()}");
            Console.WriteLine($"Estimated Cost: {EstimatedCost} EG");
            Console.WriteLine($"Extra Fee : {ExtraFee:C}");
        }
        public string GetTrackingStatus()
        {
            return $"Shipment {TrackingCode} is Ready.";
        }
        public decimal CalculateInsurance()
        {
            return (8m / 100m) * EstimatedCost;
        }
    }



    public class InternationalShipment : Shipment, ITrackable, IInsurable
    {

        private string destinationCountry;
        private decimal customsFee;

        public string DestinationCountry
        {
            get
            {
                return destinationCountry;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    destinationCountry = value;
                }
            }
        }
        public decimal CustomsFee
        {
            get
            {
                return customsFee;
            }
            set
            {
                if (value >= 0)
                {
                    customsFee = value;
                }
            }
        }
        public override decimal EstimatedCost
        {
            get
            {
                return DeliveryFee + (Weight * 5) + CustomsFee;
            }
        }
        public InternationalShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination, string destinationCountry, decimal customsFee)
            : base(trackingCode, description, weight, deliveryFee, destination)
        {
            DestinationCountry = destinationCountry;
            CustomsFee = customsFee;
        }
        public override void PrintShipment()
        {
            Console.WriteLine($"Tracking Code : {TrackingCode}");
            Console.WriteLine($"Description   : {Description}");
            Console.WriteLine($"Weight        : {Weight} kg");
            Console.WriteLine($"Delivery Fee  : {DeliveryFee:C}");
            Console.WriteLine($"Destination   : {Destination.GetFullAddress()}");
            Console.WriteLine($"Estimated Cost: {EstimatedCost} EG");
            Console.WriteLine($"Dest Country : {DestinationCountry}");
            Console.WriteLine($"Customs Fee   : {CustomsFee:C}");
        }
        public string GetTrackingStatus()
        {
            return $"Shipment {TrackingCode} is Ready.";
        }
        public decimal CalculateInsurance()
        {
            return (12m / 100m) * EstimatedCost;
        }
    }
}
