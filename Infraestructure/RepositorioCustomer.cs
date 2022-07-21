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
    public class RepositorioCustomer : IRepositorioCustomer
    {
        BDInstrumentMusical bbdd = new BDInstrumentMusical();
        public void changeCustomer(Customer customer)
        {
            bbdd.abrir();

            //Almacenar en BBDDInstrumentMusical

            SqlCommand change = new SqlCommand("changeCustomer", bbdd.ConexionBD());

            change.CommandType = CommandType.StoredProcedure;

            change.Parameters.Add(new SqlParameter("@dni", SqlDbType.Float).Value = customer.Dni());

            change.Parameters.Add(new SqlParameter("@name", SqlDbType.VarChar, 20).Value = customer.Name());

            change.Parameters.Add(new SqlParameter("@email", SqlDbType.VarChar, 20).Value = customer.Email());

            change.ExecuteNonQuery();
            
            bbdd.cerrar();
        }

        public void sigInCustomer(Customer customer)
        {
            bbdd.abrir();

            //Almacenar en BBDDInstrumentMusical

            SqlCommand sigIn = new SqlCommand("LoadCustomer", bbdd.ConexionBD());

            sigIn.CommandType = CommandType.StoredProcedure;

            sigIn.Parameters.Add(new SqlParameter("@dni", SqlDbType.Float).Value = customer.Dni());

            sigIn.Parameters.Add(new SqlParameter("@dniSales", SqlDbType.Float).Value = 40501504);

            sigIn.Parameters.Add(new SqlParameter("@name", SqlDbType.VarChar, 20).Value = customer.Name());

            sigIn.Parameters.Add(new SqlParameter("@email", SqlDbType.VarChar, 20).Value = customer.Email());

            sigIn.ExecuteNonQuery();

            bbdd.cerrar();
        }

        public void deleteCustomer(float dni)
        {
            bbdd.abrir();

            //Almacenar en BBDDInstrumentMusical

            SqlCommand delete = new SqlCommand("DeleteCustomer", bbdd.ConexionBD());

            delete.CommandType = CommandType.StoredProcedure;

            delete.Parameters.Add(new SqlParameter("@dni", SqlDbType.Float).Value = dni);

            delete.ExecuteNonQuery();

            bbdd.cerrar();
        }
    }
}
