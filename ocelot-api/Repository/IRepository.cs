using ocelot_api.Models;

namespace ocelot_api.Repository
{
    public interface IRepository
    {
        IEnumerable<Article> GetAll();
        
        Article? Get(int id);

        int Delete(int id);
    }
}
