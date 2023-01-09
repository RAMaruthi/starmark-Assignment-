using DataLayer;
using SampleFrameworksApp.Practical;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleFrameworkApp.Partical
{
    class MainUi
    {
        static IDataComponent component = new CustomerDatabase();
        static void Main(string[] args)
        {
            component.AddNewCustomer(new Customer { CustomerId = 111, CustomerName = "Ramesh Adiga", CustomerAddress = "Kundapur", BillAmount = 5600 });
            component.AddNewCustomer(new Customer { CustomerId = 131, CustomerName = "Arvind", CustomerAddress = "Ballery", BillAmount = 56000});
            component.AddNewCustomer(new Customer { CustomerId = 121, CustomerName = "Maruthi", CustomerAddress = "Davangere", BillAmount = 99600 });

            component.UpdateCustomer(new Customer { CustomerId = 111, CustomerName = "ramesh adiga", CustomerAddress = "udupi", BillAmount = 5600 });
            var data = component.GetAllCustomers();
            foreach (Customer customer in data)
                Console.WriteLine(customer.CustomerId+" " + customer.CustomerName+" "+customer.CustomerAddress+" "+customer.BillAmount);
            component.DeleteCustomer(121);

        }
    }
}
