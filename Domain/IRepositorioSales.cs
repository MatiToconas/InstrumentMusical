using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public interface IRepositorioSales
    {
        void changeSales(Sales sales);
        void sigInSales(Sales sales);
        void deleteSales(float sales);
    }
}
