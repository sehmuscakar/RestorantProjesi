using Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interfaces
{
   public interface IBookingService
    {
        IList<Booking> GetList();

        void Add(Booking booking);

        void Update(Booking booking);

        void Remove(Booking booking);

        Booking GetById(int id);


    }
}
