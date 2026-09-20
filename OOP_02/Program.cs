using System;
#nullable disable

internal class Program
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

    static public void Main()
    {
      
    }
}