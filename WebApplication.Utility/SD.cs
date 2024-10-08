using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication.Utility
{
    //STATIC DETAILS, where our constants live for application
    public static class SD
    {
        //
        public const string Role_Customer = "Customer";
        //advantage is they dont need to make the payment right away net30
        //can be registered by an admin user
        public const string Role_Company = "Company";
        //modify shipment of a product, can perform all the crud operations on product & other product managment
        public const string Role_Admin = "Admin";
        public const string Role_Employee = "Employee";
    }
}
