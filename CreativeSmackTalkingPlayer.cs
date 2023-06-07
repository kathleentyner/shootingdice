using System;
using System.Collections.Generic;
namespace ShootingDice
{
    // A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
    public class CreativeSmackTalkingPlayer : Player

{

       public List<string> taunts = new List<string>
        {
            "Your such a LOSER!.",
            "I'd rather sit on a cactus that play with you",
            "My rabbit rolls better than you"
        };

      public override int Roll()
        {


         
            // random class assigned to "random" so we can use it later
            Random random = new Random();

            int randomTaunt = new Random().Next(0, 4); //remember that arrays start at 0
            string Taunt = taunts[randomTaunt];

            Console.WriteLine($"{Name} shouts {Taunt} as they roll the dice.");
             
                  return new Random().Next(DiceSize) + 1;// Return a random number between 1 and DiceSize
      



        }

    }
}