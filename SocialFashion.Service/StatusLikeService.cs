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

    public interface IStatusLikeService
    {
        StatusLike Add(StatusLike statusLike);

        void Update(StatusLike statusLike);

        void Delete(int id);

        IEnumerable<StatusLike> GetAll();

        StatusLike GetById(int id);

        void SaveChanges();
    }
    public class StatusLikeService : IStatusLikeService
    {
        IStatusLikeRepository _statusLikeRepository;
        IUnitOfWork _unitOfWork;

        public StatusLikeService(IStatusLikeRepository statusLikeRepository, IUnitOfWork unitOfWork)
        {
            this._statusLikeRepository = statusLikeRepository;
            this._unitOfWork = unitOfWork;
        }

        public StatusLike Add(StatusLike statusLike)
        {
           return  _statusLikeRepository.Add(statusLike);
        }

        public void Delete(int id)
        {
            _statusLikeRepository.Delete(id);
        }

        public IEnumerable<StatusLike> GetAll()
        {
            return _statusLikeRepository.GetAll();
        }

        public StatusLike GetById(int id)
        {
            return _statusLikeRepository.GetSingleById(id);
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(StatusLike statusLike)
        {
            _statusLikeRepository.Update(statusLike);
        }
    }
}
