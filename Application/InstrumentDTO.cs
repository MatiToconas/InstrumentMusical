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
    public class InstrumentDTO
    {
        int idInstruments;
        int dniCustomer;
        string names;
        string tipo;
        float precio;

        public InstrumentDTO(int idInstruments, int dniCustomer, string names, string tipo, float precio)
        {
            instruments instrument = new instruments(idInstruments, names, dniCustomer, tipo, precio);

            if (instrument.Dni() != false)
            {
                // Luego podremos usarla desde cualquier otro lugar
                BDInstrumentMusical bbdd = new BDInstrumentMusical();
                bbdd.abrir();

                //Almacenar en BBDDInstrumentMusical

                SqlCommand alta = new SqlCommand("LoadInstruments", bbdd.ConexionBD());

                alta.CommandType = CommandType.StoredProcedure;

                alta.Parameters.Add(new SqlParameter("@idInstruments", SqlDbType.VarChar, 8).Value = idInstruments);

                alta.Parameters.Add(new SqlParameter("@dniCustomer", SqlDbType.Float).Value = dniCustomer);

                alta.Parameters.Add(new SqlParameter("@names", SqlDbType.VarChar, 20).Value = names);

                alta.Parameters.Add(new SqlParameter("@tipo", SqlDbType.VarChar, 30).Value = tipo);

                alta.Parameters.Add(new SqlParameter("@precio", SqlDbType.Float).Value = precio);

                alta.ExecuteNonQuery();
            }
        }
    }
}
