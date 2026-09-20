using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;
using static OOP_02.Program;
#nullable disable

namespace OOP_02
{
    public class StandardShipment  : Shipment
    {
 public StandardShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination) : base(trackingCode, description, weight, deliveryFee, destination) { }
        public override string ToString()
        {
            return $"TrackingCode = {TrackingCode}  , Description = {Description} , Weight = {Weight} , DeliveryFee = {DeliveryFee}, Destination = {Destination}";
        }

    }



}

