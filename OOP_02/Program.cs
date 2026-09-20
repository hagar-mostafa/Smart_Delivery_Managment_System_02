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
            //public override string ToString()
            //{
            //    return $"TrackingCode = {TrackingCode}  , Description = {Description} , Weight = {Weight} , DeliveryFee = {DeliveryFee}, Destination = {Destination}";
            //}

        }
        #endregion
        static void Main(string[] args)
        {
            // 1. Create a DeliveryCenter
            DeliveryCenter center = new DeliveryCenter();

            // 2. Read the center name from the user
            Console.Write("Enter Center Name: ");
            center.CenterName = Console.ReadLine();

            // 3. Create one StandardShipment
            Console.WriteLine("\n--- Enter Standard Shipment Data ---");
            Console.Write("Tracking Code: ");
            string stdCode = Console.ReadLine();
            Console.Write("Description: ");
            string stdDesc = Console.ReadLine();
            Console.Write("Weight: ");
            decimal stdWeight = decimal.Parse(Console.ReadLine());
            Console.Write("Delivery Fee: ");
            decimal stdFee = decimal.Parse(Console.ReadLine());
            Console.Write("City: ");
            string stdCity = Console.ReadLine();
            Console.Write("Street: ");
            string stdStreet = Console.ReadLine();
            Console.Write("Building Number: ");
            int stdBuilding = int.Parse(Console.ReadLine());

            StandardShipment standard = new StandardShipment(
                stdCode, stdDesc, stdWeight, stdFee,
                new DeliveryAddress(stdCity, stdStreet, stdBuilding)
            );

            // 4. Create one ExpressShipment
            Console.WriteLine("\n--- Enter Express Shipment Data ---");
            Console.Write("Tracking Code: ");
            string expCode = Console.ReadLine();
            Console.Write("Description: ");
            string expDesc = Console.ReadLine();
            Console.Write("Weight: ");
            decimal expWeight = decimal.Parse(Console.ReadLine());
            Console.Write("Delivery Fee: ");
            decimal expFee = decimal.Parse(Console.ReadLine());
            Console.Write("City: ");
            string expCity = Console.ReadLine();
            Console.Write("Street: ");
            string expStreet = Console.ReadLine();
            Console.Write("Building Number: ");
            int expBuilding = int.Parse(Console.ReadLine());

            ExpressShipment express = new ExpressShipment(
                expCode, expDesc, expWeight, expFee,
                new DeliveryAddress(expCity, expStreet, expBuilding)
            );

            // 5. Create one InternationalShipment
            Console.WriteLine("\n--- Enter International Shipment Data ---");
            Console.Write("Tracking Code: ");
            string intCode = Console.ReadLine();
            Console.Write("Description: ");
            string intDesc = Console.ReadLine();
            Console.Write("Weight: ");
            decimal intWeight = decimal.Parse(Console.ReadLine());
            Console.Write("Delivery Fee: ");
            decimal intFee = decimal.Parse(Console.ReadLine());
            Console.Write("City: ");
            string intCity = Console.ReadLine();
            Console.Write("Street: ");
            string intStreet = Console.ReadLine();
            Console.Write("Building Number: ");
            int intBuilding = int.Parse(Console.ReadLine());

            InternationalShipment international = new InternationalShipment(
                intCode, intDesc, intWeight, intFee,
                new DeliveryAddress(intCity, intStreet, intBuilding)
            );

            // 7. Add the shipments to the delivery center
            center.AddShipment(standard);
            center.AddShipment(express);
            center.AddShipment(international);

            // 8. Print all shipments
            Console.WriteLine("\n========= All Shipments =========");
            center.PrintAllShipments();

            // 9. Search for a shipment using tracking code indexer
            Console.Write("\nEnter tracking code to search: ");
            string searchCode = Console.ReadLine();
            Shipment found = center[searchCode];
            if (found != null)
            {
                Console.WriteLine("\n--- Shipment Found ---");
                found.PrintShipment();
            }
            else
            {
                Console.WriteLine("Shipment not found.");
            }

            // 10. Remove one shipment using its tracking code
            Console.Write("\nEnter tracking code to remove: ");
            string removeCode = Console.ReadLine();
            bool removed = center.RemoveShipment(removeCode);
            if (removed)
                Console.WriteLine("Shipment removed successfully.");
            else
                Console.WriteLine("Shipment not found.");

            // 11. Print the remaining shipments
            Console.WriteLine("\n========= Remaining Shipments =========");
            center.PrintAllShipments();
        }

    }
}