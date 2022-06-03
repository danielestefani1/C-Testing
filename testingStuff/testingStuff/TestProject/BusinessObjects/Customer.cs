using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Daniele Stefani
 * 10/02/2022
 */

namespace BusinessObjects
{
    public class Customer : Person//creating a class for the customers information
    {
        public Customer(int IDNumber, String first, String second) : base(IDNumber, first, second)
        {

        }
    }
}

