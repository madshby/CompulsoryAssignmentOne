using System.Collections.Generic;
using PetShop.Core.IServices;
using PetShop.Core.Models;
using PetShop.Domain.IRepositories;

namespace PetShop.Domain.Services
{
    public class PetService : IPetService
    {
        private List<Pet> petList = new List<Pet>();

        private IPetRepositories _repo;

        public PetService(IPetRepositories repo)
        {
            _repo = repo;
        }

        public List<Pet> GetAllPets()
        {
            return _repo.GetAllPets();
        }

        public List<Pet> GetPetsByType(string searchedWords)
        {
            List<Pet> searchedPets = new List<Pet>();
            petList = GetAllPets();
            foreach (var pet in petList)
            {
                if (pet.Type.Name == searchedWords.ToLower())
                {
                    searchedPets.Add(pet);
                }
            }
            return searchedPets;
        }

        public Pet CreatePet(Pet pet)
        {
            return _repo.CreatePet(pet);
        }
    }
}