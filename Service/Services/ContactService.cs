using Repository.Entities;
using Repository.Interfaces;
using Repository.Repositories;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class ContactService : IContactService
    {

        IContactRepository _contactRepository;

        public ContactService(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }

        public void Add(Contact contact)
        {
           _contactRepository.Add(contact);
        }

        public Contact GetById(int id)
        {
            Expression<Func<Contact, bool>> filter = x => x.Id == id;
            return _contactRepository.Get(filter);
        }

        public IList<Contact> GetList()
        {
            var data = _contactRepository.GetActiveList();
            return data;
        }

        public void Remove(Contact contact)
        {
         _contactRepository.Delete(contact);
        }

        public void Update(Contact contact)

        {
            contact.UpdatedAt = DateTime.Now;
            _contactRepository.Update(contact);
        }
    }
}
