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
        void Add(Fan fan);

        void Update(Fan fan);

        void Delete(int id);

        IEnumerable<Fan> GetAll();

        Fan GetById(int id);

        void SaveChanges();
    }

    class FanService : IFanService
    {
        IFanService _fanRepository;
        IUnitOfWork _unitOfWork;

        public FanService(IFanService fanRepository, IUnitOfWork unitOfWork)
        {
            this._fanRepository = fanRepository;
            this._unitOfWork = unitOfWork;
        }

        public void Add(Fan fan)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Fan> GetAll()
        {
            throw new NotImplementedException();
        }

        public Fan GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void Update(Fan fan)
        {
            throw new NotImplementedException();
        }
    }
}
