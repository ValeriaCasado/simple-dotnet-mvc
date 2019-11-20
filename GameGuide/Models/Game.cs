using System.Collections;
using System.Collections.Generic;
using Game;

namespace Game.Models
{
  public class GameElement
  {
      public int Rating { get; set; }
      public string Name { get; set ; }
      
      public GameElement(int r, string n ) {
          Rating = r;
          Name = n;
      }

  }
}