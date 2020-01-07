using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appVentas.BusinessEntities
{
    public class ProductoBE
    {
        public string CodProd { get; set; }
        public string NomProd { get; set; }
        public string CodGrup { get; set; }
        public string CodLin { get; set; }
        public string Marca { get; set; }        
        public decimal CosPromC { get; set; }        
        public decimal? PrecioVta { get; set; }
    }
}
