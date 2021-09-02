using System;
using System.Collections.Generic;
using PetShop.Core.Models;
using PetShop.Domain.IRepositories;

namespace PetShop.Infrastructure.Data.Repositories
{
    public class PetShopRepository : IPetRepositories, IPetTypeRepositories
    {
        private static List<Pet> _petTable = new List<Pet>();
        private static List<PetType> _petTypeTable = new List<PetType>();
        private static int _id = 1;
        
        public List<Pet> GetAllPets()
        {
            return _petTable;
        }

        public Pet CreatePet(Pet pet)
        {
            pet.Id = _id++;
            _petTable.Add(pet);
            return pet;
        }
    }
}