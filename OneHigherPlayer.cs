using System; 

namespace ShootingDice
{
    // TODO: Complete this class

    // Override the Play method to make a Player who always roles one higher than the other player
    public class OneHigherPlayer : Player //player is the parent/base class
 {
        // override Play() 
        public override void Play(Player other)
        { //define what the rolls are
            int myRoll = Roll();
            int otherRoll= myRoll + 1;

            Console.WriteLine($"{Name} rolls a {myRoll}");
            Console.WriteLine($"{other.Name} rolls a {otherRoll}");
           
        }

    }
}