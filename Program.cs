using System;
using gnome_leprechaun.Controllers;
using gnome_leprechaun.Interfaces;

namespace gnome_leprechaun
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();
      IGameController gc = new GameController();
      gc.Run();
    }
  }
}
