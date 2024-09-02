using FlipCart.WebAPI.Model;

namespace FlipCart.WebAPI.Services
{
    public interface ICatagoryService
    {
        public IEnumerable<Catagory> GetAll();

        public Catagory GetById(int id);

        public Catagory GetByName(string name);

        public int Create(Catagory catagory);

        public int Update(Catagory catagory);

        public void Delete(int id);


    }
}
