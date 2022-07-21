using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class instruments
    {
        private int idInstruments;
        private string names;
        private int dniCustomer;
        private string tipo;
        private float precio;
        public instruments(int idInstruments, string names, int dniCustomer, string tipo, float precio)
        {
            this.idInstruments = idInstruments;
            this.names = names;
            this.dniCustomer = dniCustomer;
            this.tipo = tipo;
            this.precio = precio;
        }
        public bool Dni()
        {
            return new Dni(dniCustomer).ShouldHaveValidDni();
        }

    }
}
