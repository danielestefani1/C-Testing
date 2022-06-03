using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;
/* Daniele Stefani
 * 10/02/2022
 */
namespace DataLayer
{

    public class DataFacadeSingleton// a singleton check if other classes contains the same data and prevents duplications
    {

        private static DataFacadeSingleton reference;

        private DataFacadeSingleton() { }

        public static DataFacadeSingleton getInstance()
        {
            if (reference == null)
                reference = new DataFacadeSingleton();

            return reference;
        }



        private Database db = new Database();


        public void addChalet(Chalet m)
        {
            db.add(m.code, m);

        }


        public Chalet getChalet(int code)
        {
            return db.get(code);
        }
    }
}
