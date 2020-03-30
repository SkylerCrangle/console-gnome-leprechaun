using System.Collections.Generic;
using gnome_leprechaun.Interfaces;

namespace gnome_leprechaun.Models
{
  class Room : IRoom
  {
    public string Name { get; set; }
    public string Description { get; set; }
    public List<IItem> Items { get; set; }
    public Dictionary<string, IRoom> Exits { get; set; }
    public Dictionary<IItem, KeyValuePair<string, IRoom>> LockedExits { get; set; }

    public void AddLockedRoom(IItem key, string direction, IRoom room)
    {
      var lockedRoom = new KeyValuePair<string, IRoom>(direction, room);
      LockedExits.Add(key, lockedRoom);
    }

    public string Use(IItem item)
    {
      if (LockedExits.ContainsKey(item))
      {
        Exits.Add(LockedExits[item].Key, LockedExits[item].Value);
        LockedExits.Remove(item);
        if (item.Name.ToLower() == "sprinkler")
        {
          return @"
          You attach the sprinkler to the hose, water flys int the air,
          and at last your rainbow appears in the distance to the east
          
                                 _.--'_......----........
                        _,i,,-'' __,,...........___
                      ,;-' _.--''    ___,,......___
                    ,;'_,''   _.--'''    __,,......
                  ,;','   _.-'   _,.--'''__,,......
      .-.        //,'   ,'   _.-'_,.--'''  .-.
     ;. .;      ///  ,-'  ,-' ,-'  .-.    ;. .;
 .- -.. ..- `. /// ,'  ,-' ,-'    ;. ..- -.. ..- `.
 `. _.(_)._ .'/// /  ,' ,-'   .' -.. .`. _.(_)._ .'
    /.' '.   /// / ,' ,'      `. _.(_)._ /.' '.  
   ,';' ';   |||/ - ,'            .` `.\,';' ';
   |  '-'    \oOoO '              ;` `;`|  '-'
   |         oOoOOo                `-`  |
   \        (_____)                     \
    |        )   (                       |
    `.      (_____)                      `.
MMWwwMmWwMmWwMmWwMmWwMmWwMmWwMmWwMmWwMmWwMmWwMmWwMm
          
          
          
          ";
        }
        if (item.Name.ToLower() == "wrench")
        {
          //shed.Room.Description = "new description";
          return @"
     
             .-.'  '.-.
          .-(   \  /   )-.
         /   '..oOOo..'   \
 ,       \.--.oOOOOOOo.--./
 |\  ,   (   :oOOOOOOo:   )
_\.\/|   /'--'oOOOOOOo'--'\
'-.. ;/| \   .''oOOo''.   /
.--`'. :/|'-(   /  \   )-'
 '--. `. / //'-'.__.'-;
   `'-,_';//      ,  /|
        '((       |\/./_
          \\  . |\; ..-'
           \\ |\: .'`--.
            \\, .' .--'
             ))'_,-'`
       jgs  //-'
           // 
          //
         |/
      Today was the perfect day to tinker on the door knob. 
      The shed to the north, now opens smoothly.";
        }


        return "You have unlocked a room";


      }
      return "No use for that here";
    }

    public Room(string name, string description)
    {
      Name = name;
      Description = description;
      Items = new List<IItem>();
      Exits = new Dictionary<string, IRoom>();
      LockedExits = new Dictionary<IItem, KeyValuePair<string, IRoom>>();
    }
  }
}