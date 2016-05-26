using DIExample.Library.Data.Infrastructure;
using DIExample.Library.Data.Repository;
using DIExample.Library.Models;
using System.Collections.Generic;

namespace DIExample.Service
{
    #region Interface
    public interface IProductService
    {
        IEnumerable<Product> GetProducts();
        Product GetProduct(int id);
        void CreateProduct(Product product);
        void SaveProduct();
    }
    #endregion Interface

    public class ProductService : IProductService
    {
        private readonly IProductRepository productsRepository;
        private readonly IUnitOfWork unitOfWork;

        public ProductService(IProductRepository productsRepository, IUnitOfWork unitOfWork)
        {
            this.productsRepository = productsRepository;
            this.unitOfWork = unitOfWork;
        }

        #region IProductService Members

        public IEnumerable<Product> GetProducts()
        {
            var products = productsRepository.GetAll();
            return products;
        }

        public Product GetProduct(int id)   
        {
            var product = productsRepository.GetById(id);
            return product;
        }

        public void CreateProduct(Product product)
        {
            productsRepository.Add(product);
        }

        public void SaveProduct()
        {
            unitOfWork.Commit();
        }

        #endregion

    }
}