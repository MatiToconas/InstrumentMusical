using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Application
{
    public class AbmSales
    {
        private IRepositorioSales repositorioSales;
        public AbmSales(IRepositorioSales repositorioSales)
        {
            this.repositorioSales = repositorioSales;
        }
        public void change(SalesDTO salesDTO)
        {
            Sales sales = Sales.CrearDesdePrimitivos(salesDTO.Dni(), salesDTO.Password());
            this.repositorioSales.changeSales(sales);
        }
        public void sigIn(SalesDTO salesDTO)
        {
            Sales sales = Sales.CrearDesdePrimitivos(salesDTO.Dni(), salesDTO.UserName(), salesDTO.Password());
            this.repositorioSales.sigInSales(sales);
        }
        public void delete(float dni)
        {
            this.repositorioSales.deleteSales(dni);
        }
    }
}
