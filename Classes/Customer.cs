using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Customer
    {
       //field - alan
       // public string FirstName;
        

        //property - özellik
        public int Id { get; set; }
        public string FirsName { get; set; }

        //private string _firsName;      
        //public string FirstName 
        //{ 
        //    get { return "Mrs. " + _firsName; }
        //    set { _firsName = value; }
        //}
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
