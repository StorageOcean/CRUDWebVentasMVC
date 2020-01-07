using appVentas.BusinessEntities;
using appVentas.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appVentas.BusinessLogic
{
    public class ProductoBL
    {
        private ProductoDA productoDA;

        public ProductoBL()
        {
            this.productoDA = new ProductoDA();
        }

        public List<ProductoBE> GetAllProductos()
        {
            return productoDA.GetAllProductos();
        }

        public ProductoBE GetByIdProducto(ProductoBE producto)
        {
            return productoDA.GetByIdProducto(producto);
        }

        public bool InsertProducto(ProductoBE producto)
        {
            return productoDA.InsertProducto(producto);
        }

        public bool UpdateProducto(ProductoBE producto)
        {
            return productoDA.UpdateProducto(producto);
        }

        public bool DeleteProducto(ProductoBE producto)
        {
            return productoDA.DeleteProducto(producto);
        }
    }
}
