using gnome_leprechaun.Interfaces;

namespace gnome_leprechaun.Models
{
  class Game : IGame
  {
    public IPlayer CurrentPlayer { get; set; }
    public IRoom CurrentRoom { get; set; }

    ///<summary>Initalizes data and establishes relationships</summary>
    public Game()
    {
      // NOTE ALL THESE VARIABLES ARE REMOVED AT THE END OF THIS METHOD
      // We retain access to the objects due to the linked list


      // NOTE Create all rooms
      Room home = new Room("Home Section", @"
    .
        ('
        '|
        |'
       [::]
       [::]   _......_
       [::].-'      _.-`.
       [:.'    .-. '-._.-`.
       [/ /\   |  \        `-..
       / / |   `-.'      .-.   `-.
      /  `-'            (   `.    `.
     |           /\      `-._/      \
     '    .'\   /  `.           _.-'|
    /    /  /   \_.-'        _.':;:/
  .'     \_/             _.-':;_.-'
 /   .-.             _.-' \;.-'
/   (   \       _..-'     |
\    `._/  _..-'    .--.  |
 `-.....-'/  _ _  .'    '.|
          | |_|_| |      | \  (o)
     (o)  | |_|_| |      | | (\'/)
    (\'/)/  ''''' |     o|  \;:;
     :;  |        |      |  |/)
      ;: `-.._    /__..--'\.' ;:
          :;  `--' :;   :;
You are currently inside your tiny gnome home.
It's small and simple, with only one door, on the south wall.    


            ");


      Room shed = new Room("Shed", @"

            _______
            /\\\\\\\\
           /__\\\\\\\\ 
           |__|_|_|__|  
           |  |/|0| /| 
        ~~~~~~~~~~~~~~~~~~~~~~~
               
        Lots of useful tools insdie, you're a garden gnome, that's just what you do.");


      Room eastYard = new Room("East Yard", @"Vast fields of gardens, garden gnome - sculptures, a bird bath, and a garden hose.

                    _
                  _(_)_                          wWWWw   _
      @@@@       (_)@(_)   vVVVv     _     @@@@  (___) _(_)_
     @@()@@ wWWWw  (_)\    (___)   _(_)_  @@()@@   Y  (_)@(_)
      @@@@  (___)     `|/    Y    (_)@(_)  @@@@   \|/   (_)\
       /      Y       \|    \|/    /(_)    \|      |/      |
    \ |     \ |/       | / \ | /  \|/       |/    \|      \|/
jgs \\|//   \\|///  \\\|//\\\|/// \|///  \\\|//  \\|//  \\\|// 
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

      From here you can get to either the front yard or the backyard.");


      Room frontYard = new Room("Front Yard", @"
       
Your gnome property is most excellent, you are in the front yard right now, but you have more yards to either side. And the street to the south.

There is a letter in your mailbox, you look and see - it's from your friend,
---------------------------------------------------------------
       'Dear Gnomie Homie,

       I've been trying to come and visit you,
       but alas, I'm stuck at the end of the raindbow
       in the dead of summer.
       We really need some rain!

       Wishing you well,
       Lemmy Leprechaun'
--------------------------------------------------------------------       
       
       ");


      EndRoom street = new EndRoom("Street", @"You wander into the street. The street is hot from the summer sun.
      
                .
            .
            |
      '.  _..._  .'
        .'     '.
   '-. /         \ .-'
 _ _  ; D E A T H ;  _ _
       \         /
    .-' '._   _.' '-.
       .   ```   .
jgs   '     |     '
            '
            '
      
      
      
      ", false, "Your bare feet burn and you have to spend the next week inside");

      Room backYard = new Room("Back Yard", @"
      The backyard has a bunch of incomplete projects waiting for your tinkering.
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
      There's a shed to the north, but the door knob is old and difficult to open. Perhaps there's a tool that would help you open it.");

      Room westYard = new Room("West Yard", @"The yard to the west of the house is yet another expanse of beautifully kept gnome gardens.


           ____
       _.-'78o `'`--._
   ,o888o.  .o888o,   ''-.
 ,88888P  `78888P..______.]
/_..__..----'''        __.'
`-._       /''| _..-''
    '`-----\  `\
            |   ;.-''--..
            | ,8o.  o88. `.
            `;888P  `788P  :
      .o''-.|`-._         ./
     J88 _.-/    ';'-P----'
     `--'\`|     /  /
         | /     |  |
         \|     /   |akn
          `-----`---'


      From here you can get to eaither the front yard or the backyard");

      EndRoom rainbow = new EndRoom("Rainbow", @"
      The sprinkler sprays water into the air, creating a gnome-made rainbow.

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
      
      
      
      ", true, "You finally connect with your good friend Lemmy the Leprechaun! And he shares with you from his pot of gold for finding him, somehow, in the dead of summer.");

      //   EndRoom westYard = new EndRoom("Toiletries", "A hoarde of people are racing through this aisle with their weapons out", false, "You are trampled under foot and your name is lost to history");

      // NOTE Create all Items
      Item wrench = new Item("Wrench", "perfect for tinkering with sockets");
      Item sprinkler = new Item("sprinkler", "sprays water into the air and onto the plants");

      // NOTE Make Room Relationships
      home.Exits.Add("south", frontYard);
      frontYard.Exits.Add("south", street);
      frontYard.Exits.Add("west", westYard);
      frontYard.Exits.Add("east", eastYard);

      westYard.Exits.Add("se", frontYard);
      westYard.Exits.Add("ne", backYard);

      eastYard.Exits.Add("sw", frontYard);
      eastYard.Exits.Add("nw", backYard);

      // backYard.Exits.Add("north", shed);
      backYard.Exits.Add("east", eastYard);
      backYard.Exits.Add("west", westYard);

      shed.Exits.Add("south", backYard);

      backYard.AddLockedRoom(wrench, "north", shed);
      eastYard.AddLockedRoom(sprinkler, "east", rainbow);


      // NOTE put Items in Rooms
      shed.Items.Add(sprinkler);
      frontYard.Items.Add(wrench);


      CurrentRoom = home;
    }
  }
}