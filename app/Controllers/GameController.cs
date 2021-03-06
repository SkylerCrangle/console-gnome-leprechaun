using System;
using System.Threading;
using gnome_leprechaun.Interfaces;
using gnome_leprechaun.Services;

namespace gnome_leprechaun.Controllers
{
  class GameController : IGameController
  {
    private IGameService _gs { get; set; }
    private bool _running { get; set; } = true;
    public void Run()
    {
      Console.WriteLine("Greetings lad, what is your gnome name?");
      // NOTE Gets string from readline and passes is as the player name
      _gs = new GameService(Console.ReadLine());
      string greeting = @"
      
         __________________________________________
________|              __             __           |_______
\       |     | __ |  |__  |    |    |  |          |      /
 \      |     |    |  |__  |__  |__  |__|          |     /
 /      |__________________________________________|     \
/__________)                                   (__________\
      
      GoodMorning, you woke up in your gnome home thinking about your leprechaun friend.
      
       
       You'd very much like to speak with him, but it's the dead of summer and hasn't rained in a while. 
       
       
       Good Luck!";
      foreach (char letter in greeting)
      {
        Console.Write(letter);
        //Thread.Sleep(100);
      }
      Console.WriteLine();
      Print();
      while (_running)
      {
        GetUserInput();
        Print();
      }
    }
    public void GetUserInput()
    {
      // go north
      // take brass key
      // command option
      // look
      // command
      Console.WriteLine("What would you like to do?");
      string input = Console.ReadLine().ToLower() + " "; //go north ;take toilet paper ;look 
      string command = input.Substring(0, input.IndexOf(" ")); //go; take; look
      string option = input.Substring(input.IndexOf(" ") + 1).Trim();//north; toilet paper;''

      Console.Clear();
      switch (command)
      {
        case "quit":
          _running = false;
          break;
        case "reset":
          _gs.Reset();
          break;
        case "look":
          _gs.Look();
          break;
        case "inventory":
          _gs.Inventory();
          break;
        case "help":
          _gs.Help();
          break;
        case "go":
          _running = _gs.Go(option);
          break;
        case "take":
          _gs.Take(option);
          break;
        case "use":
          _gs.Use(option);
          break;
        default:
          _gs.Messages.Add("Not a recognized command");
          _gs.Look();
          break;
      }
    }

    public void Print()
    {
      foreach (string message in _gs.Messages)
      {
        Console.WriteLine(message);
      }
      _gs.Messages.Clear();
    }

  }
}