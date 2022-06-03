using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public class Person
    {
        private int iDNumber;//creating private strings for guests data
        private string firstName;
        private string surname;

        public Person(int IDNumber, String first, String second)
        {
            iDNumber = IDNumber;
            firstName = first;
            surname = second;
        }
        public int BookingID//Id number value
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

        public String FirstName //value get set for name
        {
            get
            {
                return firstName;
            }

            set
            {
                firstName = value;
            }
        }

        public String Surname //input the surname
        {
            get
            {
                return surname;
            }
            set
            {
                surname = value;
            }
        }

        public int IDNumber//value for the guests ID number
        {
            set { IDNumber = value; }
            get { return IDNumber; }
        }
    }
}
