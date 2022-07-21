using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Dni
    {
        int dni;
        public Dni(int dni)
        {
            this.dni = dni;
        }
        public bool ShouldHaveValidDni()
        {
            string n;
            bool esNumero;
            do
            {
                n = Console.ReadLine();
                /* Si es número correcto retornará true y saldrá
                   *  del Ciclo*/
                esNumero = int.TryParse(n, out dni);
            }
            while (!esNumero);
            Console.WriteLine("El Valor Ingresado es " + n);

            return esNumero;
        }

    }
}
