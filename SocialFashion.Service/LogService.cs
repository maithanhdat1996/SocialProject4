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
    public interface ILogService
    {
        void Add(Log log);

        void SaveChanges();
    }
    public class LogService : ILogService
    {
        ILogRepository _logRepository;
        IUnitOfWork _unitOfWork;

        public LogService(ILogRepository logRepository, IUnitOfWork unitOfWork)
        {
            this._logRepository = logRepository;
            this._unitOfWork = unitOfWork;
        } 

        public void Add(Log log)
        {
            _logRepository.Add(log);
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }
    }
}
