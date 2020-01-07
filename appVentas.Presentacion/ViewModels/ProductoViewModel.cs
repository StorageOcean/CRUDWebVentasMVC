using appVentas.BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace appVentas.Presentacion.ViewModels
{
    public class ProductoViewModel
    {
        public ProductoBE productoBE { get; set; }

        public List<ProductoBE> listProductoBE { get; set; }
        public List<LineaBE> listLineaBE { get; set; }
        public List<GrupoBE> listGrupoBE { get; set; }
    }
}