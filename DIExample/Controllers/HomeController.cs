using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DIExample.Library.Data;
using DIExample.Service;
using DIExample.Library.Models;
using DIExample.ViewModels;
using AutoMapper;

namespace DIExample.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductService productService;
       
        public HomeController(IProductService productService)
        {
            this.productService = productService;
        }
        
        [HttpGet]
        public ActionResult Index()
        {
            IEnumerable<ProductViewModel> viewModel;
            IEnumerable<Product> products = productService.GetProducts();

            // Map our products to our ViewModel
            viewModel = Mapper.Map<IEnumerable<Product>, IEnumerable<ProductViewModel>>(products);

            return View(viewModel);          
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View(new ProductViewModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public PartialViewResult AddProduct(ProductViewModel product)
        {
            // Ideally we would be doing some server-side validation here.
            Product newProduct = Mapper.Map<ProductViewModel, Product>(product);
            productService.CreateProduct(newProduct);
            productService.SaveProduct();

            // Map back
            product = Mapper.Map<Product, ProductViewModel> (newProduct);
            return PartialView("AddSaved", product);
        }

        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if (id.HasValue)
            {
                Product product = productService.GetProduct(id.Value);
                if (product != null)
                {
                    ProductViewModel viewModel = Mapper.Map<Product, ProductViewModel>(product);
                    return View(viewModel);
                }
                else
                {
                    // Product with specified ID does not exist, return to index
                    return RedirectToAction("Index");
                }
            }
            else
            {
                // No id, back to index we go
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public PartialViewResult EditProduct(ProductViewModel editedProduct)
        {
            // Ideally we would be doing some server-side validation here.
            Product product = productService.GetProduct(editedProduct.ProductID);

            if (product != null)
            {
                // A method to map the view model and then sync properties would probably be
                // best but for ease of showing workflow doing it here
                product.ProductName = editedProduct.ProductName;
                product.CategoryName = editedProduct.CategoryName;
                product.Price = editedProduct.Price;
                product.StockCount = editedProduct.StockCount;

                productService.SaveProduct();

                return PartialView("EditSaved", editedProduct);
            }
            else
            {
                // Can't edit a product that doesn't exist - throw error.
                return PartialView("Error");
            }
        }

        [HttpGet]
        public ActionResult Details(int? id)
        {
            if (id.HasValue)
            {
                Product product = productService.GetProduct(id.Value);
                if (product != null)
                {
                    ProductDetailedViewModel viewModel = Mapper.Map<Product, ProductDetailedViewModel>(product);
                    return View(viewModel);
                }
                else
                {
                    // Product with specified ID does not exist, return to index
                    return RedirectToAction("Index");
                }
            }
            else
            {
                // No id, back to index we go
                return RedirectToAction("Index");
            }
        }
    }
}