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

    public interface IProductTypeService
    {
        ProductType Add(ProductType productType);

        void Update(ProductType productType);

        void Delete(int id);

        IEnumerable<ProductType> GetAll();

        ProductType GetById(int id);

        void SaveChanges();
    }
    public class ProductTypeService : IProductTypeService
    {
        IProductTypeRepository _productTypeRepository;
        IUnitOfWork _unitOfWork;

        public ProductTypeService(IProductTypeRepository productTypeRepository, IUnitOfWork unitOfWork)
        {
            this._productTypeRepository = productTypeRepository;
            this._unitOfWork = unitOfWork;
        }

        public ProductType Add(ProductType productType)
        {
            return _productTypeRepository.Add(productType);
        }

        public void Delete(int id)
        {
            _productTypeRepository.Delete(id);
        }

        public IEnumerable<ProductType> GetAll()
        {
            return _productTypeRepository.GetAll();
        }

        public ProductType GetById(int id)
        {
            return _productTypeRepository.GetSingleById(id);
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(ProductType productType)
        {
            _productTypeRepository.Update(productType);
        }
    }
}
