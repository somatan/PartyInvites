using Microsoft.AspNetCore.Mvc;
using PartyInvites.Models;

namespace PartyInvites.Controllers
{
  public class HomeController : Controller
  {
    public ViewResult Index()
    {
      var hour = DateTime.Now.Hour;
      this.ViewBag.Greeting = hour < 12 ? "Good Morning" : "Good Afternoon";
      return this.View();
    }

    [HttpGet]
    public ViewResult RsvpForm()
    {
      return this.View();
    }

    [HttpPost]
    public ViewResult RsvpForm(GuestResponse guestResponse)
    {
      if (this.ModelState.IsValid)
      {
         return this.View("Thanks", guestResponse);
      }
      else
      {
         return this.View();
      }
    }
  }
}