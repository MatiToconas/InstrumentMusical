using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class AbmCustomer
    {
        private IRepositorioCustomer repositorioCustomer;
        public AbmCustomer(IRepositorioCustomer repositorioCustomer)
        {
            this.repositorioCustomer = repositorioCustomer;
        }
        public void change(CustomerDTO CustomerDTO)
        {
            Customer customer = Customer.CrearDesdePrimitivos(CustomerDTO.Dni(), CustomerDTO.Name(), CustomerDTO.Email());
            this.repositorioCustomer.changeCustomer(customer);
        }
        public void sigIn(CustomerDTO CustomerDTO)
        {
            Customer customer = Customer.CrearDesdePrimitivos(CustomerDTO.Dni(), CustomerDTO.Name(), CustomerDTO.Email());
            this.repositorioCustomer.sigInCustomer(customer);
        }
        public void delete(float dni)
        {
            this.repositorioCustomer.deleteCustomer(dni);
        }
    }
}
