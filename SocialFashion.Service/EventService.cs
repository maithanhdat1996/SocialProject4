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
    public interface IEventService
    {
        Event Add(Event e);

        void Update(Event e);

        void Delete(int id);

        IEnumerable<Event> GetAll();

        Event GetById(int id);

        void SaveChanges();
    }

    public class EventService : IEventService
    {
        IEventRepository _eventRepository;
        IUnitOfWork _unitOfWork;

        public EventService(IEventRepository eventRepository, IUnitOfWork unitOfWork)
        {
            this._eventRepository = eventRepository;
            this._unitOfWork = unitOfWork;
        }

        public Event Add(Event e)
        {
            return _eventRepository.Add(e);
        }

        public void Delete(int id)
        {
            _eventRepository.Delete(id);
        }

        public IEnumerable<Event> GetAll()
        {
            return _eventRepository.GetAll();
        }

        public Event GetById(int id)
        {
            return _eventRepository.GetSingleById(id);
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(Event e)
        {
            _eventRepository.Update(e);
        }
    }
}
