using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;
using DataLayer;
/* Daniele Stefani
 * 10/02/2022
 */
namespace DataLayer
{
    class Database//database class to store and retrieve data 

    {
        private Dictionary<int, Chalet> db = new Dictionary<int, Chalet>();//dictionary created for the chalet class

        // Metod to add a chalet to the database
        public void add(int k, Chalet val)
        {
            if (db.ContainsKey(k))
            {
                db[k] = val;
            }
            else
            {
                db.Add(k, val);
            }
        }

        public Chalet get(int val)
        {
            return db[val];
        }


        private Dictionary<int, Customer> data = new Dictionary<int, Customer>();

        public void add(int k, Customer val)
        {
            if (data.ContainsKey(k))
            {
                data[k] = val;
            }
            else
            {
                data.Add(k, val);
            }
        }

        private Dictionary<int, Guest> data2 = new Dictionary<int, Guest>();//dictionary to store keys for the guests class
        public void add(int k, Guest val)
        {
            if (data2.ContainsKey(k))
            {
                data2[k] = val;
            }
            else
            {
                data2.Add(k, val);
            }
        }



    }
}



