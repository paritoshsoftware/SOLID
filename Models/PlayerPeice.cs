using Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class PlayerPeice
    {
        public PlayerPeieceType peieceType;
        public PlayerPeice(PlayerPeieceType peieceType) { 
        
            this.peieceType = peieceType;   
        }
    }
}
