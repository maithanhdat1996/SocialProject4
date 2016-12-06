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
    public interface INotificationService
    {
        Notification Add(Notification notification);

        void Update(Notification notification);

        void Delete(int id);

        IEnumerable<Notification> GetAll();

        Notification GetById(int id);

        void SaveChanges();
    }

    public class NotificationService : INotificationService
    {
        INotificationRepository _notificationRepository;
        IUnitOfWork _unitOfWork;

        public NotificationService(INotificationRepository notificationRepository, IUnitOfWork unitOfWork)
        {
            this._notificationRepository = notificationRepository;
            this._unitOfWork = unitOfWork;
        }

        public Notification Add(Notification notification)
        {
            return _notificationRepository.Add(notification);
        }

        public void Delete(int id)
        {
            _notificationRepository.Delete(id);
        }

        public IEnumerable<Notification> GetAll()
        {
            return _notificationRepository.GetAll();
        }

        public Notification GetById(int id)
        {
            return _notificationRepository.GetSingleById(id);
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(Notification notification)
        {
            _notificationRepository.Update(notification);
        }
    }
}
