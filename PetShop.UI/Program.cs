using PetShop.Core.IServices;
using PetShop.Domain.IRepositories;
using PetShop.Domain.Services;
using PetShop.Infrastructure.Data.Repositories;

namespace PetShop.UI
{
    public class Program
    {
        static void Main(string[] args)
        {
            IPetRepositories repoOne = new PetShopRepository();
            IPetService serviceOne = new PetService(repoOne);
            var menu = new Menu(serviceOne);
            menu.Start();
            //Cheapish DI (Dependency Injection)
            //IVideoRepository repo = new VideoRepositoryInMemory();
            //IVideoService service = new VideoService(repo);
            //var menu = new Menu(service);
            //menu.Start();
        }
    }
}