using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Dal = Veri Tabanı İşleri

namespace İnterfaces
{
    internal interface ICustomerDal
    {
        void Add();
        void Update();
        void Delete();
    }

    class SqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Sgl added");
        }

        public void Delete()
        {
            Console.WriteLine("Sgl deleted");
        }

        public void Update()
        {
            Console.WriteLine("Sgl updated");
        }
    }

    class OracleCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Sgl added");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle deleted");
        }

        public void Update()
        {
            Console.WriteLine("Oracle updated");
        }

        internal class CustomerManager
        {
            public void Add(ICustomerDal customerDal)
            {
                customerDal.Add();
            }
        }
    }
}
