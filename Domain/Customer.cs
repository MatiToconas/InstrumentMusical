using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Customer
    {
        private Dni dni;
        private Name name;
     // private Surname surname;
        private Email email;
        public Customer(Dni dni, Name name, Email email)
        {
            this.dni = dni;
            this.name = name;
            this.email = email;
        }
      /* public bool Dni()
        {
            return new Dni(dni).ShouldHaveValidDni();
        }*/

        public static Customer CrearDesdePrimitivos(int dni, string name, string email)
        {
            return new Customer(new Dni(dni), new Name(name), new Email(email));              
        }

        public void Change(Dni dni, Name name, Email email)
        {
            this.dni = dni;
            this.name = name;
            this.email = email;
        }

        public Dni Dni()
        {
            return this.dni;
        }
        public Name Name()
        {
            return this.name;
        }
        public Email Email()
        {
            return this.email;
        }
    }
}
