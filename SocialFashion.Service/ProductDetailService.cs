using SocialFashion.Data.Infrastructure;
using SocialFashion.Data.Repositories;
using SocialFashion.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialFashion.Service
{
    
    public interface IProductDetailService
    {
        ProductDetail Add(ProductDetail productDetail);

        void Update(ProductDetail productDetail);

        void Delete(int id);

        IEnumerable<ProductDetail> GetAll();

        ProductDetail GetById(int id);

        void SaveChanges();
    }
    public class ProductDetailService : IProductDetailService
    {
        IProductDetailRepository _productRepository;
        IUnitOfWork _unitOfWork;

        public ProductDetailService(IProductDetailRepository productRepository, IUnitOfWork unitOfWork)
        {
            this._productRepository = productRepository;
            this._unitOfWork = unitOfWork;
        }

        public ProductDetail Add(ProductDetail productDetail)
        {
            return _productRepository.Add(productDetail);
        }

        public void Delete(int id)
        {
            _productRepository.Delete(id);
        }

        public IEnumerable<ProductDetail> GetAll()
        {
            return _productRepository.GetAll();
        }

        public ProductDetail GetById(int id)
        {
            return _productRepository.GetSingleById(id);
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(ProductDetail productDetail)
        {
            _productRepository.Update(productDetail);
        }
    }
}
