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

    public interface IStatusService
    {
        Status Add(Status status);

        void Update(Status status);

        void Delete(int id);

        IEnumerable<Status> GetAll();

        Status GetById(int id);

        void SaveChanges();
    }
    public class StatusService : IStatusService
    {
        IStatusRepository _statusRepository;
        IUnitOfWork _unitOfWork;

        public StatusService(IStatusRepository statusRepository, IUnitOfWork unitOfWork)
        {
            this._statusRepository = statusRepository;
            this._unitOfWork = unitOfWork;
        }

        public Status Add(Status status)
        {
            return _statusRepository.Add(status);
        }

        public void Delete(int id)
        {
            _statusRepository.Delete(id);
        }

        public IEnumerable<Status> GetAll()
        {
            return _statusRepository.GetAll();
        }

        public Status GetById(int id)
        {
            return _statusRepository.GetSingleById(id);
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(Status status)
        {
            _statusRepository.Update(status);
        }
    }
}
