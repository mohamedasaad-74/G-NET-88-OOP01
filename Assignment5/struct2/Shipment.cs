using Assignment5.struct1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization.Metadata;
using System.Threading.Tasks;

namespace Assignment5.struct2
{
    public class Shipment
    {
        #region Q4


        private string Trackingcode;
        private string Description;
        private double Weight;
        private decimal Deliveryfee;
        private DelivryAddress Destination;
        public string trackingcode
        {

            get
            {
                return Trackingcode;
            }
        }
        public string description
        {
            get { return Description; }

            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    Description = value;

                }

            }
        }
        public double weight
        {
            get { return Weight; }

            set
            {
                if (value > 0)
                {
                    Weight = value;

                }
            }
        }

        public decimal deliveryfee
        {
            get { return Deliveryfee; }
            private set
            {
                if (value > 0)
                {
                    Deliveryfee = value;
                }
            }
        }
        public DelivryAddress destination
        {
            get { return Destination; }
            set { Destination = value; }
        }
        public double EstimatedCost
        {
            get { return (double)Deliveryfee + (Weight * 5); }
        }
        public Shipment(string TrackingCode)

        {

            this.Trackingcode = TrackingCode;
            Description = "unknown";
            Weight = 1;
            Deliveryfee = 50;
            Destination = new DelivryAddress();

        }
        public Shipment(string TrackingCode, string Description, double Weight, decimal Delivryfee, DelivryAddress Destination)
        {
            Description = string.IsNullOrWhiteSpace(description) ? "Unknown" : description;
            Weight = weight > 0 ? weight : 1.0;
            Deliveryfee = Deliveryfee > 0 ? Deliveryfee : 50;
            Destination = destination;

        }
        public void UpdateDeliveryFee(decimal newFee)
        {
            if (newFee > 0)
            {
                Deliveryfee = newFee;
            }
        }
        public override string ToString()
        {
            return $"{Trackingcode} ,{Description}, {Weight} ,{Deliveryfee}. {Destination}.{EstimatedCost} ";


        }
        public void PrintShipment()
        {
               Console.WriteLine(this.ToString());
            }
        #endregion
        }
}    

    
    
    





    


        
    
