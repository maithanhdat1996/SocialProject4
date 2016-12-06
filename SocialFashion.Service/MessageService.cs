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
    public interface IMessageService
    {
        Message Add(Message message);

        void Update(Message message);

        void Delete(int id);

        IEnumerable<Message> GetAll();

        Message GetById(int id);

        void SaveChanges();
    }

    public class MessageService : IMessageService
    {
        IMessageRepository _messageRepository;
        IUnitOfWork _unitOfWork;

        public MessageService(IMessageRepository messageRepository, IUnitOfWork unitOfWork)
        {
            this._messageRepository = messageRepository;
            this._unitOfWork = unitOfWork;
        }

        public Message Add(Message message)
        {
            return _messageRepository.Add(message);
        }

        public void Delete(int id)
        {
            _messageRepository.Delete(id);
        }

        public IEnumerable<Message> GetAll()
        {
            return _messageRepository.GetAll();
        }

        public Message GetById(int id)
        {
            return _messageRepository.GetSingleById(id);
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(Message message)
        {
            _messageRepository.Update(message);
        }
    }
}
