using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo.Abstract
{
    public interface ICustomerService
    {
        void Save(Customer customer);
    }

    public class Customer
    {
        public string FirstName { get; internal set; }
        public DateTime DateOfBirth { get; internal set; }
    }
}
