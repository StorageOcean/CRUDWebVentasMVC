using appVentas.BusinessEntities;
using appVentas.BusinessLogic;
using appVentas.Presentacion.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace appVentas.Presentacion.Controllers
{
    public class ProductoController : Controller
    {
        private ProductoBL productoBL;
        private LineaBL lineaBL;
        private GrupoBL grupoBL;

        public ProductoController()
        {
            productoBL = new ProductoBL();
            lineaBL = new LineaBL();
            grupoBL = new GrupoBL();
        }
        // GET: Producto
        public ActionResult Index()
        {
            ProductoViewModel viewModel = new ProductoViewModel();
            viewModel.listProductoBE = productoBL.GetAllProductos();
            return View(viewModel);
        }

        public ActionResult NuevoProducto()
        {
            ProductoViewModel viewModel = new ProductoViewModel();
            viewModel.listLineaBE = lineaBL.GetAllLineas();
            viewModel.listGrupoBE = grupoBL.GetAllGrupos();
            return View(viewModel);     
        }

        public ActionResult GuardarProducto(ProductoViewModel viewModel)
        {
            ProductoBE productoBE = viewModel.productoBE;
            ViewBag.message = productoBL.InsertProducto(productoBE) ? "OK" : "";
            return RedirectToAction("Index");
        }


        public ActionResult EditarProducto(string idProducto)
        {
            ProductoViewModel viewModel = new ProductoViewModel();
            ProductoBE productoBE = new ProductoBE
            {
                CodProd = idProducto
            };
            viewModel.productoBE = productoBL.GetByIdProducto(productoBE);
            viewModel.listLineaBE = lineaBL.GetAllLineas();
            viewModel.listGrupoBE = grupoBL.GetAllGrupos();
            return View(viewModel);
        }

        public ActionResult ActualizarProducto(ProductoViewModel viewModel)
        {
            ProductoBE productoBE = viewModel.productoBE;
            ViewBag.message = productoBL.UpdateProducto(productoBE) ? "OK" : "";
            return RedirectToAction("Index");
        }


        public ActionResult EliminarProducto(string idProducto)
        {
            ProductoBE productoBE = new ProductoBE
            {
                CodProd = idProducto
            };
            productoBL.DeleteProducto(productoBE);
            return RedirectToAction("Index");
        }


    }
}