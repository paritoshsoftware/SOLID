using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Player
    {
        public string Name { get; set; }  

        public PlayerPeice PlayerPeice { get; set; }

        public Player(string Name, PlayerPeice playerPeice)
        {
            this.Name = Name;
            this.PlayerPeice = playerPeice;
        }

    }
}
