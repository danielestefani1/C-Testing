using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Daniele Stefani
 * 10/02/2022
 */

// class for the chalet details
namespace BusinessObjects
{
    public class Chalet

    {
        private String _name;
        private int _code;
        List<Booking> bookingList = new List<Booking>();//creating a integer list to store information for the booking
        List<Customer> customerList = new List<Customer>();
        public int Cost { get; set; }
        public String Name { get; set; }


        private List<Customer> cust = new List<Customer>();//Customer list  an get-set
        public int code
        {
            get
            {
                return _code;
            }

            set
            {
                _code = value;
            }
        }

        public String name
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

        public void addCustomer(int IDNumber, String first, String second)
        {//adding a booking name and Id
            customerList.Add(new Customer(IDNumber, first, second));
        }
    }

    /* 
     public String RoomList
     {
         get
         {
             String list = "";
             foreach (Customers s in name){
                 list=list + s.IDNumber + " : " + s.name + "\n";
             }
             return list;
         } 
     }*/

}

