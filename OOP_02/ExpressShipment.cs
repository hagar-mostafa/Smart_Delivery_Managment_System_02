using System;
using System.Collections.Generic;
using System.Text;
using static OOP_02.Program;

namespace OOP_02
{
    public class ExpressShipment : Shipment
    {
        private decimal _ExtraFee;
        public decimal ExtraFee
        {
            get
            {
                return _ExtraFee;
            }
            set
            {
                if (_ExtraFee >= 0)
                    _ExtraFee = value;
            }
        }
            public override decimal EstimatedCost
        {
            get
            {
                return DeliveryFee + (Weight * 5) + ExtraFee;
            }
        }
            public ExpressShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination) : base(trackingCode, description, weight, deliveryFee, destination) {
            ExtraFee = _ExtraFee;
        }
    }
    }
    

