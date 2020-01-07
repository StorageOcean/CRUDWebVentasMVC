using appVentas.BusinessEntities;
using appVentas.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appVentas.BusinessLogic
{
    public class LineaBL
    {

        private LineaDA lineaDA;

        public LineaBL()
        {
            this.lineaDA = new LineaDA();
        }

        public List<LineaBE> GetAllLineas()
        {
            return lineaDA.GetAllLineas();
        }
    }
}
