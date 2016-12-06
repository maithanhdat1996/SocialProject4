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
    public interface IFanService
    {
        Fan Add(Fan fan);

        void Update(Fan fan);

        void Delete(int id);

        IEnumerable<Fan> GetAll();

        Fan GetById(int id);

        void SaveChanges();
    }

    class FanService : IFanService
    {
        IFanRepository _fanRepository;
        IUnitOfWork _unitOfWork;

        public FanService(IFanRepository fanRepository, IUnitOfWork unitOfWork)
        {
            this._fanRepository = fanRepository;
            this._unitOfWork = unitOfWork;
        }

        public Fan Add(Fan fan)
        {
            return _fanRepository.Add(fan);
        }

        public void Delete(int id)
        {
            _fanRepository.Delete(id);
        }

        public IEnumerable<Fan> GetAll()
        {
            return _fanRepository.GetAll();
        }

        public Fan GetById(int id)
        {
            return _fanRepository.GetSingleById(id);
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(Fan fan)
        {
            _fanRepository.Update(fan);
        }
    }
}
