namespace PetShop.UI
{
    public class StringConstants
    {
        //Menu Choices
        public const string PrintPetListText = "Please press 1 to show all pets.";
        public const string SearchByPetTypeText = "Please press 2 to search by pet type.";
        public const string CreateANewPetText = "Please press 3 to create a new pet.";
        public const string DeleteAPetText = "Please press 4 to delete a pet.";
        public const string UpdateAPetText= "Please press 5 to update a specific pets info.";
        public const string SortPetsByPriceText= "Please press 6 to sort pets by price.";
        public const string GetFiveCheapestAvailablePetsText= "Please press 7 to see the five cheapest available pets.";

        //Menu Messages
        public const string SearchPetTypeByNameText = "Please write the type of pet you would like to search for:";
        public const string HereIsAListOfAllPets = "Here is a list of all pets:";
        public const string PleaseEnterPetName = "Please enter the pet name:";
        public const string PleaseEnterPetType = "Please enter the pet type:";
        public const string PleaseEnterPetBirthday = "Please enter the pets birthdate:";
        public const string PleaseEnterPetSoldDate = "Please enter the date where the pet was sold:";
        public const string PleaseEnterPetColor = "Please enter the pet color:";
        public const string PleaseEnterPetPrice = "Please enter the pet price:";
        public const string PetHasBeenCreatedText = "Pet with the following properties has been created:";
       

        //Errors
        public const string SearchResultEqualsZero = "Couldn't find a matching pet type, returning to main menu.";
        public const string PetListIsEmptyText = "Couldn't find any results, returning to main menu.";
        public const string NamesCannotContainNumbersText = "Names cannot contain numbers...";
    }
}