using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpListOfObjectsByBroCode50._45
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // How to create a list of objects form a custom class
            // for example lets create a list of players to keep track of names within a game

            List<Player> players = new List<Player>();

            Player player1 = new Player("Chad");
            Player player2 = new Player("Steve");
            Player player3 = new Player("Karen");
            //we can instantiate player objects anonymously by using the add method like so... (and it'll be less work)
            players.Add(new Player("Chad"));
            players.Add(new Player("Steve"));
            players.Add(new Player("Karen"));

            players.Add(player1);
            players.Add(player2);
            players.Add(player3);

            foreach (Player player in players)
            {
                Console.WriteLine(player);// overriding the tostring method will allow this line of code to accurately displaty the names of players
            }
            //but since this is displaying each object directly console will display the data type and name of the object
            // so instead we can access the username field...
            foreach (Player player in players)
            {
                Console.WriteLine(player.username);
            }
            // or override the tostring method... (see tostring override on the bottom)

        }
        class Player
        {
            public String username;

            public Player(String username)
            {
                this.username = username;
            }
            public override string ToString()
            {
                return username;
            }
        }
    }
}
