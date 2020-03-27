using System.Collections.Generic;

namespace gnome_leprechaun.Interfaces
{
  interface IPlayer
  {
    string Name { get; set; }
    List<IItem> Inventory { get; set; }
  }
}