using System.ComponentModel.Design;

namespace Guys_and_Cash
{
    internal class Program
    {
        static void Main( string[] args )
        {
            Guy joe = new Guy() { Cash = 50, Name = "Joe" };
            Guy bob = new Guy() { Cash = 100, Name = "Bob" };

            while ( true )
            {
                joe.WriteMyInfo();
                bob.WriteMyInfo();

                Console.Write( "Enter an amount: " );
                string? howMuch = Console.ReadLine();
                if ( howMuch == "" ) return;
                if ( int.TryParse( howMuch, out int amount ) )
                {
                    Console.WriteLine( "Who should give the cash: " );
                    string? whichGuy = Console.ReadLine();
                    if ( whichGuy == "Joe" )
                    {
                        joe.GiveCash( amount );
                        bob.ReceiveCash( amount );
                    }
                    else if ( whichGuy == "Bob" )
                    {
                        bob.GiveCash( amount );
                        joe.ReceiveCash( amount );
                    }
                    else
                    {
                        Console.WriteLine( "Please enter Joe or Bob" );
                    }
                }
                else
                {
                    Console.WriteLine( "Please enter an amount (or a blank line to exit)." );
                }
            }
        }
    }
}
