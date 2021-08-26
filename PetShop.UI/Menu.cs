using System;
using System.Collections.Generic;
using System.Linq;
using PetShop.Core.IServices;
using PetShop.Core.Models;

namespace PetShop.UI
{
    public class Menu : IMenu
    {
        private IPetService _petService;

        public Menu(IPetService petService)
        {
            _petService = petService;
        }

        public void Start()
        {
            StartLoop();
        }

        private void StartLoop()
        {
            int choice;
            while ((choice = GetMainMenuSelection()) != 0)
            {
                if (choice == 1)
                {
                    GetAllPets();
                }
                else if (choice == 2)
                {
                    SearchByPetType();
                }
                else if (choice == 3)
                {
                    CreateNewPet();
                }
            }
        }
        
        private int GetMainMenuSelection()
        {
            ShowMainMenu();
            var selectionString = Console.ReadLine();
            int selection;
            if (int.TryParse(selectionString, out selection))
            {
                return selection;
            }
            return -1;
        }
        private void ShowMainMenu()
        {
            Console.WriteLine("");
            Console.WriteLine(StringConstants.PrintPetListText);
            Console.WriteLine(StringConstants.SearchByPetTypeText);
            Console.WriteLine(StringConstants.CreateANewPetText);
        }

        private void GetAllPets()
        {
            Console.Clear();
            List<Pet> pets = _petService.GetAllPets();
            if (pets.Count == 0)
            {
                Console.WriteLine(StringConstants.PetListIsEmptyText);
            }
            else
            {
                foreach (var pet in pets)
                {
                    Console.WriteLine(StringConstants.HereIsAListOfAllPets);
                    Console.WriteLine($"{pet.Id} - {pet.Name} - {pet.Type}");
                }
            }
        }
        private void SearchByPetType()
        {
            Console.Clear();
            Console.WriteLine(StringConstants.SearchPetTypeByNameText);
            string input = Console.ReadLine()?.ToLower();
            List<Pet> tempPetList = _petService.GetPetsByType(input);
            if (tempPetList.Count == 0)
            {
                Console.WriteLine(StringConstants.SearchResultEqualsZero);
            }
            else
            {
                foreach (var pet in tempPetList)
                {
                    Console.WriteLine(pet);
                }
            }
        }
        
        private void CreateNewPet()
        {
            Console.Clear();
            // Name
            Console.WriteLine(StringConstants.PleaseEnterPetName);
            var petName = Console.ReadLine();
            if (petName.All(char.IsDigit))
            {
                Console.WriteLine(StringConstants.NamesCannotContainNumbersText);
                Console.WriteLine(StringConstants.PleaseEnterPetName);
                petName = Console.ReadLine();
            }
            // Type
            Console.WriteLine(StringConstants.PleaseEnterPetType);
            PetType newPetType = new PetType();
            var petType = Console.ReadLine();
            newPetType.Name = petType;
            // Birthday
            Console.WriteLine(StringConstants.PleaseEnterPetBirthday);
            var petBirthDate = Console.ReadLine();
            // SoldDate
            Console.WriteLine(StringConstants.PleaseEnterPetSoldDate);
            var petSoldDate = Console.ReadLine();
            // Color
            Console.WriteLine(StringConstants.PleaseEnterPetColor);
            var petColor = Console.ReadLine();
            // Price
            Console.WriteLine(StringConstants.PleaseEnterPetPrice);
            var petPrice = Console.ReadLine();
            
            var pet = new Pet()
            {
                Name = petName,
                Type = newPetType,
                BirthDate = Convert.ToDateTime(petBirthDate),
                SoldDate = Convert.ToDateTime(petSoldDate),
                Color = petColor,
                Price = Convert.ToDouble(petPrice)
            };
            pet = _petService.CreatePet(pet);
            Console.WriteLine(StringConstants.PetHasBeenCreatedText);
            Console.Write($"ID: {pet.Id} - Name: {pet.Name} - Type: {pet.Type.Name} - BirthDate: {pet.BirthDate:dd/MM/yyyy} - SoldDate: {pet.SoldDate:dd/MM/yyyy} - Color: {pet.Color} - Price: {pet.Price}");
            Console.WriteLine("");
        }

    }
}