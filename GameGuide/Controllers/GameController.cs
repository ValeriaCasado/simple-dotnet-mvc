using Microsoft.AspNetCore.Mvc;
using Game.Models;

namespace Game.Controllers
{
  public class GameController : Controller
  {
    [Route("/poop")]
    public string Sentence() { return "Valeria needs love, any audience member interested?"; }

    [Route("/anthony")]
    public string Valeria() { return "My pussy is throbbing"; }

    [Route("/sigh")]
    public string sigh() { return "sigh"; }
    
    /*
    
    VIEWS => public ActionResult viewName()
    STRINGS => public string stringName()

     */

    [Route("/Home")]
    public ActionResult Home() { return View(); }

    [Route("/Form")]
    public ActionResult Form() { return View(); }

    [Route("/Show")]
    public ActionResult Show(int rating, string name) { 
        GameElement game = new GameElement(rating, name);
        
        return View(game); }

   }
   
}
 
 