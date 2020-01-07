using appVentas.BusinessEntities;
using appVentas.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appVentas.BusinessLogic
{
    public class GrupoBL
    {
        private GrupoDA grupoDA;

        public GrupoBL()
        {
            this.grupoDA = new GrupoDA();
        }

        public List<GrupoBE> GetAllGrupos()
        {
            return grupoDA.GetAllGrupos();
        }
    }
}
