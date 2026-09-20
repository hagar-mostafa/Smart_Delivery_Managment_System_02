using System;
using System.Collections.Generic;
using System.Text;
using static OOP_02.Program;
#nullable disable
namespace OOP_02
{
    public class InternationalShipment : Shipment
    {
        private string _DestinationCountry;
        private decimal _CustomsFee;

        public string DestinationCountry
        {
            get
            {
                return _DestinationCountry;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    _DestinationCountry = value;
            }
        }
        public decimal CustomsFee
        {
            get
            {
                return _CustomsFee;
            }
            set
            {
                if (_CustomsFee >= 0)
                    _CustomsFee = value;
            }
        }
        public override decimal EstimatedCost
        {
            get
            {
                return CustomsFee + (Weight * 5) + CustomsFee;
            }
        }
        public InternationalShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination) : base(trackingCode, description, weight, deliveryFee, destination)
        {
            CustomsFee = _CustomsFee;
        }
    }
}
