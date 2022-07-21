using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Name
    {
        string name;
        public Name(string name)
        {
            this.name = name;
        }

        public bool ShouldHaveValidName()
        {
            int nameReturn;
            bool esNumero;
            do
            {
              esNumero = int.TryParse(name, out nameReturn);
            }
            while (!esNumero);
            //Console.WriteLine("El Valor Ingresado es " + name);

            return !esNumero;
        }
    }
}
