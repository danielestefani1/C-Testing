using System;
using System.Collections.Generic;
using BusinessObjects;

//using DataLayer;

/* Daniele Stefani 
 * 10/02/2022
 * */
namespace BusinessObjects
{
    public class Booking//this class is created for the bookings
    {

        private int IDCustomer;
        private String name;

        public Booking(int IDNumber, String n)//create the string to store the required parameter
        {
            BookingID = IDNumber;
            name = n;
        }

        public Booking()
        {
        }

        public int BookingID//Id number for the bookings, get, set to create a property
        {
            get
            {
                return BookingID;
            }

            set
            {
                BookingID = value;
            }
        }

        public String Name //string array plus property get,set
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public DateTime arrival// date arrival property
        {
            get
            {
                return arrival;
            }
            set
            {
                arrival = value;
            }
        }

        public String Address
        {
            get
            {
                return Address;
            }
            set
            {
                Address = value;
            }
        }

        public String room1//string for room choice
        {
            get
            {
                return room1;
            }
            set
            {
                room1 = value;
            }
        }

        public String Surname
        {
            get
            {
                return Surname;
            }
            set
            {
                Surname = value;
            }
        }
    }
}
