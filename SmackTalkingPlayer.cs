using System; 

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player who shouts a taunt every time they roll dice
    public class SmackTalkingPlayer : Player //add the play parent class
    {
        public string Taunt  = "Yo mama so dumb that your dice just gave up."; //a taunt

  public override int Roll(){//need to override the roll function to have the smack talker say the taunt before the player function executes.
            
             Console.WriteLine($"{Name} shouts {Taunt} as they roll the dice.");
             
                  return new Random().Next(DiceSize) + 1;// Return a random number between 1 and DiceSize
      
        }

    }
}
