using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public interface IRepositorioCustomer
    {
        void changeCustomer(Customer customer);
        void sigInCustomer(Customer customer);
        void deleteCustomer(float dni);
    }
}
