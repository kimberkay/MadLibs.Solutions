using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Form() {return View(); }
    [Route("/story")]
    public ActionResult Story(string adjectiveOne, string foodPlural, string verbOne, string saying, string nounOne, string foodPluralTwo, string color, string vehicle, string animal, string person)
    {
      //create an object from models
      PartsOfSpeech transferObject = new PartsOfSpeech();
      //assign its properties using info from the form
      transferObject.AdjectiveOne = adjectiveOne;
      transferObject.FoodPlural = foodPlural;
      transferObject.VerbOne = verbOne;
      transferObject.Saying = saying;
      transferObject.NounOne = nounOne;
      transferObject.FoodPluralTwo = foodPluralTwo;
      transferObject.Color = color;
      transferObject.Vehicle = vehicle;
      transferObject.Animal = animal;
      transferObject.Person = person;
      //return a view with that object as an argument (we will need to make a Story.cshtml)
      return View(transferObject);
    }
  }
}