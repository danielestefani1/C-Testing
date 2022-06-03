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
    public class Guest : Person
    {
        //this refers to the constructor in Person.class
        public Guest(int IDNumber, String first, String second) : base(IDNumber, first, second)
        {


        }
    }
}
