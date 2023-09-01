using Repository.Entities;
using Repository.Interfaces;
using Service.Interfaces;
using System.Linq.Expressions;

namespace Service.Services
{
    public class TestimanialServices : ITestimonialService
    {
        ITestimaonialRepository _testimaonialRepository;

        public TestimanialServices(ITestimaonialRepository testimaonialRepository)
        {
            _testimaonialRepository = testimaonialRepository;
        }

        public void Add(Testimonial testimonial)
        {
           _testimaonialRepository.Add(testimonial);
        }

        public Testimonial GetById(int id)
        {
            Expression<Func<Testimonial, bool>> filter = x => x.Id == id;
            return _testimaonialRepository.Get(filter);
        }

        public IList<Testimonial> GetList()
        {
            var data = _testimaonialRepository.GetActiveList();
            return data;
        }

        public void Remove(Testimonial testimonial)
        {
           _testimaonialRepository.Delete(testimonial);
        }

        public void Update(Testimonial testimonial)
        {
            testimonial.UpdatedAt = DateTime.Now;
            _testimaonialRepository.Update(testimonial);
        }
    }
}
