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
    public class SalesDTO
    {
        int dni;
        string userName;
        string password;
        
        public SalesDTO(int dni, string userName, string password)
        {
            this.dni = dni;
            this.userName = userName;
            this.password = password;
        }

        public int Dni()
        {
            return this.dni;
        }
        public string UserName()
        {
            return this.userName;
        }
        public string Password()
        {
            return this.password;
        }
    }
}
