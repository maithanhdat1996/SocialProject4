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
    public interface IBranchService
    {
        Branch Add(Branch branch);

        void Update(Branch branch);

        void Delete(int id);

        IEnumerable<Branch> GetAll();

        Branch GetById(int id);

        void SaveChanges();
    }
    public class BranchService : IBranchService
    {
        IBranchRepository _branchRepository;
        IUnitOfWork _unitOfWork;

        public BranchService(IBranchRepository branchRepository, IUnitOfWork unitOfWork)
        {
            this._branchRepository = branchRepository;
            this._unitOfWork = unitOfWork;
        }

        public Branch Add(Branch branch)
        {
            return _branchRepository.Add(branch);
        }

        public void Delete(int id)
        {
            _branchRepository.Delete(id);
        }

        public IEnumerable<Branch> GetAll()
        {
            return _branchRepository.GetAll();
        }

        public Branch GetById(int id)
        {
            return _branchRepository.GetSingleById(id);
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(Branch branch)
        {
            _branchRepository.Update(branch);
        }
    }
}
