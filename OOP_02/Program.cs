using System;
#nullable disable

namespace OOP_02
{
    public class Program
    {
        #region  Part 01 : Theoretical Questions 
        //----------------------QA-----------------------------
        /* The Difference between class and struct
         * 
         * 1. Type : Class is reference type , Struct is value type 
         * 
         * 2. Stored in : Class stored in heap , Struct stored in stack 
         * 
         * 3. inheritance : Class supports that , Struct doesn't support
         * 
         * 4. Default Constructor : Class Provided if none defined (implicit Parameterless ) , Struct the parameterless constructor always exist 
         * 
         * 5. null : Class can be null , Struct can not be null unless the ' ? '(nullable) operator
         * 
         * 6. Best for : Class with Complex data with behavior , inheritance , shared data , Struct with simple and small data
         */

        //----------------------QB-----------------------------
        /*
         As class supports inheritance and behavior in classes are more Professional (u can use override , overload , interfaces , ....)
         */

        #endregion

        #region  Part 01 : Theoretical Questions "Code"
        /*
         1. Class Parent is Shipment
         2.  The Child Class is expressShipment
         3.  he inherit the  TrackingCode Property
         4.  Duplicating makes the code more complex and that isn't Practical in real world projects
         */
        #endregion

        #region DeliveryAddress Struct
        public struct DeliveryAddress
        {

            private string City;
            private string Street;
            private int BuildingNumber;
            public DeliveryAddress(string City, string Street, int BuildingNumber)
            {
                this.City = City;
                this.Street = Street;
                this.BuildingNumber = BuildingNumber;
            }
            public string GetFullAddress()
            {
                return $"The address {City}, {Street}, {BuildingNumber}";
            }
        }
        #endregion


        #region  Shipment Class
        public class Shipment
        {
            private string _TrackingCode;
            public string TrackingCode
            {
                get
                { return _TrackingCode; }
            }
            private string _Description;
            public string Description
            {
                get { return _Description; }
                set
                {
                    if (!string.IsNullOrWhiteSpace(value))
                        _Description = value;
                }
            }
            private decimal _Weight;
            public decimal Weight
            {
                get { return _Weight; }
                set
                {
                    if (value > 0)
                        _Weight = value;
                }
            }
            private decimal _DeliveryFee;
            public decimal DeliveryFee
            {
                get { return _DeliveryFee; }
                private set
                {
                    if (value > 0)
                        _DeliveryFee = value;
                }

            }
            private DeliveryAddress _Destination;
            public DeliveryAddress Destination
            {
                get
                { return _Destination; }

                set
                { _Destination = value; }

            }
            // computed property
            public virtual decimal EstimatedCost
            {
                get
                {
                    return DeliveryFee + (Weight * 5);
                }
            }


            public Shipment(string trackingCode)
            {
                if (!string.IsNullOrWhiteSpace(trackingCode))
                    _TrackingCode = trackingCode;
                Description = "Unknown";
                Weight = 1;
                DeliveryFee = 50;
                Destination = new DeliveryAddress("Unknown", "Unknown", 0);
            }
            //------constructor overloading-----
            public Shipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination)
            {
                if (!string.IsNullOrWhiteSpace(trackingCode))
                    _TrackingCode = trackingCode;
                Description = description;
                Weight = weight;
                DeliveryFee = deliveryFee;
                Destination = destination;
            }
            public void UpdateDeliveryFee(decimal newFee)
            {
                if (newFee > 0)
                    DeliveryFee = newFee;
            }
            public void PrintShipment()
            {
                Console.WriteLine("This Shipment struct include the Following : ");
                Console.WriteLine($"Tracking Code is => {_TrackingCode}");
                Console.WriteLine($"The Description is => {Description}");
                Console.WriteLine($"The Weight is = {Weight}");
                Console.WriteLine($"The DeliveryFee is => {DeliveryFee}");
                Console.WriteLine($"The Destination is => {Destination.GetFullAddress()}");
                Console.WriteLine($"The EstimateCost is => {EstimatedCost}");
            }
            public override string ToString()
            {
                return $"TrackingCode = {TrackingCode}  , Description = {Description} , Weight = {Weight} , DeliveryFee = {DeliveryFee}, Destination = {Destination}";
            }

        }
        #endregion

        #region DeliveryCenter Class
        public class DeliveryCenter
        {
            private Shipment[] _shipments;
            private int _count;
            public DeliveryCenter()
            {
                _shipments = new Shipment[10];
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
                if (_count >= 10)
                    return false;

                _shipments[_count] = shipment;
                _count++;
                return true;
            }
        }
        #endregion

        static public void Main()
        {

        }
    }
}