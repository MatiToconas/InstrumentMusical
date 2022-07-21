using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using Application;

namespace Presentation
{
    public class Menu
    {
        public static void Main(string[] args)
        {
            menuRegistro();
        }


        public static void menuRegistro()
        {
            int option = 1;

            Console.WriteLine("1-Registrarse");
            Console.WriteLine("2-Loguearse");

            if (option == 1)
            {
                int dni = 0;
                String userName = "Ariel";
                String password = "123456";

                SalesDTO salesDTO = new SalesDTO(dni, userName, password);
            }
            else
            {
                menuVenta();
            }

        }

        public static void menuVenta()
        {
            int idInstruments = 0;
            string nameInstruments = "Guitarra";
            string tipo = "Cuerda";
            float precio = 10000;
            int dniCustomer = 0;

            String name = "Matias";
            String email = "m.toconas@sanatoriodeloeste.com";

            CustomerDTO customerDTO = new CustomerDTO(dniCustomer, name, email);
            InstrumentDTO instrumentDTO = new InstrumentDTO(idInstruments, dniCustomer, nameInstruments, tipo, precio);
        }
    }
}
