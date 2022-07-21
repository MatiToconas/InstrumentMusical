using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
//using Microsoft.Data.SqlClient;

namespace Infraestructure
{
    public class BDInstrumentMusical
    {
        //Cadena de Conexion
        string cadena = "data source = MATIAS-PC; initial catalog = InstrumentMusical; Integrated Security=True";

        public SqlConnection Conectarbd = new SqlConnection();

        //Constructor
        public BDInstrumentMusical()
        {
            Conectarbd.ConnectionString = cadena;
        }

        public SqlConnection ConexionBD()
        {
            return Conectarbd;
        }

        //Metodo para abrir la conexion
        public void abrir()
        {
            try
            {
                Conectarbd.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine("error al abrir BD ", ex.Message);
            }
        }

        //Metodo para cerrar la conexion
        public void cerrar()
        {
            Conectarbd.Close();
        }
    }
}
