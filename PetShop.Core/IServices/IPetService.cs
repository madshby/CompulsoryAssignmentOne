using System.Collections.Generic;
using System.Dynamic;
using PetShop.Core.Models;

namespace PetShop.Core.IServices
{
    public interface IPetService
    {
        List<Pet> GetAllPets();
        List<Pet> GetPetsByType(string searchedWords);
        Pet CreatePet(Pet pet);
    }
}