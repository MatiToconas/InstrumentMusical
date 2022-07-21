using Domain;
using Infraestructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Application
{
    public class CustomerDTO
    {
        private int dni;
        string name;
        string surname;
        string email;

        public CustomerDTO(int dni, string name, string email)
        {
            this.dni = dni;
            this.name = name;
            this.email = email;
        }
                
        public int Dni()
        {
            return this.dni;
        }
        public string Name()
        {
            return this.name;
        }
        public string Surname()
        {
            return this.surname;
        }
        public string Email()
        {
            return this.email;
        }
    }
}
