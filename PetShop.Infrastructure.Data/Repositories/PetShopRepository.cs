using System.Collections.Generic;
using PetShop.Core.Models;
using PetShop.Domain.IRepositories;

namespace PetShop.Infrastructure.Data.Repositories
{
    public class PetShopRepository : IPetRepositories
    {
        private static List<Pet> _petTable = new List<Pet>();
        public List<Pet> GetAllPets()
        {
            return _petTable;
        }
    }
}