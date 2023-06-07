using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player whose role will always be in the upper half of their possible rolls
    public class UpperHalfPlayer : Player
    {

        // will need to override Roll()
        public override int Roll() 

        
        {

            return new Random().Next(4, 6) + 1;


        }
     


        }

    }
