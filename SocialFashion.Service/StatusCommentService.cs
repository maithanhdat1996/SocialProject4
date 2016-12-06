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

    public interface IStatusCommentService
    {
        StatusComment Add(StatusComment statusComment);

        void Update(StatusComment statusComment);

        void Delete(int id);

        IEnumerable<StatusComment> GetAll();

        StatusComment GetById(int id);

        void SaveChanges();
    }
    public class StatusCommentService : IStatusCommentService
    {
        IStatusCommentRepository _statusCommentRepository;
        IUnitOfWork _unitOfWork;

        public StatusCommentService(IStatusCommentRepository statusCommentRepository, IUnitOfWork unitOfWork)
        {
            this._statusCommentRepository = statusCommentRepository;
            this._unitOfWork = unitOfWork;
        }

        public StatusComment Add(StatusComment statusComment)
        {
            return _statusCommentRepository.Add(statusComment);
        }

        public void Delete(int id)
        {
            _statusCommentRepository.Delete(id);
        }

        public IEnumerable<StatusComment> GetAll()
        {
            return _statusCommentRepository.GetAll();
        }

        public StatusComment GetById(int id)
        {
            return _statusCommentRepository.GetSingleById(id);
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(StatusComment statusComment)
        {
            _statusCommentRepository.Update(statusComment);
        }
    }
}
