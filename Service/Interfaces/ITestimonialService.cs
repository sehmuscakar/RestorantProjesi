using Repository.Entities;

namespace Service.Interfaces
{
    public interface ITestimonialService
    {
        IList<Testimonial> GetList();

        void Add(Testimonial testimonial);

        void Update(Testimonial testimonial);

        void Remove(Testimonial testimonial);

        Testimonial GetById(int id);

    }
}
