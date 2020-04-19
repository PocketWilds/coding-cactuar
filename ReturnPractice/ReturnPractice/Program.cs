using System;

namespace ReturnPractice
{
    class Program
    {

        class Mog
        {
        }

        class Malboro
        {
        }

        class Tonberry
        {
        }

        class Cactuar
        {
        }


        /* This assignment has three purposes: to review data types, returning values, and how to write functions.
         * 
         * For this assignment, you MAY NOT alter the Main method below.  This assignment must be fixed by creating functions in the classes
         * listed above.
         * 
         * There are two things to consider.  First, you have to define the functions being used in Main.  Since you can't change Main, you can't
         * change the names of the functions being called in Main.  So your only option is to write functions that match the functions being
         * called in Main.  So pay attention to how the functions are being called below!  The function calls will be marked with a comment that
         * says "FUNCTION CALL".
         * 
         * Additionally, if you look at the function calls, you'll see that the functions are providing data being stored in variables inside of
         * Main.  That means that your functions must have data that they are RETURNING.  If you look at the variables receiving that data, you
         * can tell what kind of data should be returned.
         */
        static void Main(string[] args)
        {
            // YOU MAY NOT CHANGE ANYTHING INSIDE OF MAIN FOR THIS ASSIGNMENT
            Mog mog = new Mog();
            Malboro malboro = new Malboro();
            Tonberry tonberry = new Tonberry();
            Cactuar cactuar = new Cactuar();

            String mogSound = mog.MakeSound();                                             // FUNCTION CALL
            int numberOfMalboroStatuses = malboro.BadBreathStatuses();                     // FUNCTION CALL
            double distanceFromTonberry = tonberry.GetDistanceFromPlayer();                // FUNCTION CALL
            bool isCactuarCharging = cactuar.IsCharging();                                 // FUNCTION CALL

            Console.WriteLine("The mog says " + mogSound);
            Console.WriteLine("The malboro's bad breath status inflicts " + numberOfMalboroStatuses + " statuses.");
            Console.WriteLine("The tonberry is currently " + distanceFromTonberry + " fulms away from you.");
            Console.WriteLine("Cactuar Charging Status:  " + isCactuarCharging);
            
        }
    }
}
