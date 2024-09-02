using FlipCart.WebAPI.Data;
using FlipCart.WebAPI.Model;

namespace FlipCart.WebAPI.Services
{
    public class CatagoryService : ICatagoryService
    {
        private readonly AppDbContext _context;

        public CatagoryService(AppDbContext context)
        {
            _context = context;
        }

        public int Create(Catagory catagory)
        {
            _context.catagories.Add(catagory);
            return _context.SaveChanges();

        }

        public void Delete(int id)
        {
            var cat = _context.catagories.First(c => c.Id == id);
            _context.Remove(cat);
            _context.SaveChanges();
        }

        public IEnumerable<Catagory> GetAll()
        {
            return _context.catagories.ToList();
        }

        public Catagory GetById(int id)
        {
            return _context.catagories.First(c => c.Id == id);
        }

        public Catagory GetByName(string name)
        {
            return _context.catagories.First(c => c.Name == name);
        }

        public int Update(Catagory catagory)
        {
            var cat = _context.catagories.First(c => c.Id == catagory.Id);

            cat.Name = catagory.Name;
            cat.Description = catagory.Description;
            cat.Image = catagory.Image;

            _context.catagories.Update(cat);
            return _context.SaveChanges();

        }
    }
}
