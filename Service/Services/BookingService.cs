using Repository.Entities;
using Repository.Interfaces;
using Repository.Repositories;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class BookingService : IBookingService
    {
        IBookingRepository _bookingRepository;

        public BookingService(IBookingRepository bookingRepository)
        {
            _bookingRepository = bookingRepository;
        }

        public void Add(Booking booking)
        {
            _bookingRepository.Add(booking);
        }

        public Booking GetById(int id)
        {
            Expression<Func<Booking, bool>> filter = x => x.Id == id;
            return _bookingRepository.Get(filter);
        }

        public IList<Booking> GetList()
        {
            var data = _bookingRepository.GetActiveList();
            return data;
        }

        public void Remove(Booking booking)
        {
            _bookingRepository.Delete(booking); 
        }

        public void Update(Booking booking)
        {
            booking.UpdatedAt = DateTime.Now;
            _bookingRepository.Update(booking);
        }
    }
}
