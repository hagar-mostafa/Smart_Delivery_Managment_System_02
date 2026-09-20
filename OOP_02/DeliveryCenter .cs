using System;
using System.Collections.Generic;
using System.Text;
using static OOP_02.Program;
#nullable disable
namespace OOP_02
{
    public class DeliveryCenter
    {

        public string CenterName { get; set; }

        private Shipment[] _shipments;
            private int _count;
            public DeliveryCenter()
            {
                _shipments = new Shipment[20];
                _count = 0;
            }
            // ------------------integer indexer------------------
            public Shipment this[int index]
            {
                get
                {
                    if (index < 0 || index >= _count)
                        return default;
                    return _shipments[index];
                }

                set
                {
                    if (index < 0 || index >= _count)
                        return;
                    _shipments[index] = value;
                }
            }
            // ------------------string  indexer------------------

            public Shipment this[string trackingCode]
            {
                get
                {
                    for (int i = 0; i < _count; i++)
                    {
                        if (_shipments[i].TrackingCode == trackingCode)
                            return _shipments[i];
                    }
                    return default;
                }
            }
            public bool AddShipment(Shipment shipment)
            {
                if (_count >= 20)
                    return false;

                _shipments[_count] = shipment;
                _count++;
                return true;
            }
        // ------------------RemoveShipment------------------
        public bool RemoveShipment(string trackingCode)
        {
            for (int i = 0; i < _count; i++)
            {
                if (_shipments[i].TrackingCode == trackingCode)
                {
                    // Shifting 
                    for (int j = i; j < _count - 1; j++)
                    {
                        _shipments[j] = _shipments[j + 1];
                    }
                    _shipments[_count - 1] = null; // remove last element (After shifting)
                    _count--;
                    return true;
                }
            }
            return false;
        }
        // ------------------PrintAllShipments------------------
        public void PrintAllShipments()
        {
            if (_count == 0)
            {
                Console.WriteLine("No shipments available.");
                return;
            }

            for (int i = 0; i < _count; i++)
            {
                Console.WriteLine($"--- Shipment {i + 1} ---");
                _shipments[i].PrintShipment();
            }
        }

    }
    }

