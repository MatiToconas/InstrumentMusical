using Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure
{
    public class RepositorioSales : IRepositorioSales
    {
        BDInstrumentMusical bbdd = new BDInstrumentMusical();
        public void changeSales(Sales sales)
        {
            bbdd.abrir();

            //Almacenar en BBDDInstrumentMusical

            SqlCommand change = new SqlCommand("changeSales", bbdd.ConexionBD());

            change.CommandType = CommandType.StoredProcedure;

            change.Parameters.Add(new SqlParameter("@dni", SqlDbType.Float, 8).Value = sales.Dni());

            change.Parameters.Add(new SqlParameter("@password", SqlDbType.VarChar, 20).Value = sales.Password());

            change.ExecuteNonQuery();
            
            bbdd.cerrar();

        }

        public void sigInSales(Sales sales)
        {
            bbdd.abrir();

            //Almacenar en BBDDInstrumentMusical

            SqlCommand sigIn = new SqlCommand("LoadSales", bbdd.ConexionBD());

            sigIn.CommandType = CommandType.StoredProcedure;

            sigIn.Parameters.Add(new SqlParameter("@dni", SqlDbType.Float).Value = sales.Dni());

            sigIn.Parameters.Add(new SqlParameter("@userName", SqlDbType.VarChar, 20).Value = sales.UserName());

            sigIn.Parameters.Add(new SqlParameter("@password", SqlDbType.VarChar, 20).Value = sales.Password());

            sigIn.ExecuteNonQuery();
            
            bbdd.cerrar();
        }

        public void deleteSales(float dni)
        {
            bbdd.abrir();

            //Almacenar en BBDDInstrumentMusical

            SqlCommand delete = new SqlCommand("DeleteSales", bbdd.ConexionBD());

            delete.CommandType = CommandType.StoredProcedure;

            delete.Parameters.Add(new SqlParameter("@dni", SqlDbType.Float).Value = dni);

            delete.ExecuteNonQuery();

            bbdd.cerrar();
        }
    }
}
