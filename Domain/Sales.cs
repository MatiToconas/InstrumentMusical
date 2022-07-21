using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Sales
    {
        Dni dni;
        UserName userName;
        Password password;

        public Sales(Dni dni, UserName userName, Password password)
        {
            this.dni = dni;
            this.userName = userName;
            this.password = password;
        }

        public Sales(Dni dni, Password password)
        {
            this.dni = dni;
            this.password = password;
        }

        /*  public bool Dni()
          {
              return new Dni(dni).ShouldHaveValidDni();
          }
        */
        public static Sales CrearDesdePrimitivos(int dni, string password)
        {
            return new Sales(new Dni(dni), new Password(password));
        }

        public static Sales CrearDesdePrimitivos(int dni, string userName, string password)
        {
            return new Sales(new Dni(dni), new UserName(userName), new Password(password));
        }
        
      /*  public void Change(Dni dni, Password password)
        {
            this.dni = dni;
            this.password = password;
        }
      */
        public Dni Dni()
        {
            return this.dni;
        }
     
        public Password Password()
        {
            return this.password;
        }
        public UserName UserName()
        {
            return this.userName;
        }
    }
}
