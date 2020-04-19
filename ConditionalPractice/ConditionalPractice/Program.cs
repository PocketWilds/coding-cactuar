using System;

namespace ConditionalPractice
{
    class Program
    {

        class Yojimbo
        {
            public int Payment = 0;

            public void PerformAttack()
            {
            }

            // THIS FUNCITON SHOULD NOT BE ALTERED
            void Daigoro()
            {
                Console.WriteLine("After shaking his head in disgust, Yojimbo sends his dog Daigoro to smack a single enemy for 100 damage!");
            }

            // THIS FUNCTION SHOULD NOT BE ALTERED
            void Kozuka()
            {
                Console.WriteLine("Yojimbo pulls some kozuka from under his cloak and throws them at a single enemy for 2000 damage!");
            }

            // THIS FUNCTION SHOULD NOT BE ALTERED
            void WakizashiSingle()
            {
                Console.WriteLine("Yojimbo draws his wakizashi and strikes a single enemy for 5000 damage!");
            }

            // THIS FUNCTION SHOULD NOT BE ALTERED
            void WakizashiMultiple()
            {
                Console.WriteLine("Yojimbo draws his wakizashi and strikes all enemies for 5000 damage each!");
            }

            // THIS FUNCTION SHOULD NOT BE ALTERED
            void Zanmato()
            {
                Console.WriteLine("After a nod of satisfaction, Yojimbo summons his sword from the void and charges forward, killing all enemies!");
            }
        }

        /* The objective of this assignment is to review the use of conditional statements.
         * 
         * In Main, we create a Yojimbo object, we create a payment variable, we change
         * our yojimbo object's payment variable, and then we call yojimbo's PerformAttack
         * function.
         * 
         * Yojimbo already has functions for each of his attacks and they function correctly.
         * If we call any of those functions, they describe each of Yojimbo's attacks.  But
         * they're all private functions!
         * 
         * This is because using Yojimbo as a summon means you don't get to choose the attack
         * he performs; you only get to pay him and then *he* chooses what attack to perform.
         * 
         * So the assignment is to modify the PerformAttack function so that Yojimbo performs
         * a different attack based on how much he has been paid.
         * 
         * The calculation for how he actually chooses his attack is relatively complex so
         * we'll use the simplified version of the rules listed below.
         * 
         * If Yojimbo is paid less than 100 gil, he will attack with Daigoro.
         * If Yojimbo is paid 100 or more but less than 250, he will attack with Kozuka.
         * If Yojimbo is paid 250 or more but less than 500, he will attack a single enemy
         * with his wakizashi (WakizashiSingle).
         * If Yojimbo is paid 500 or more but less than 1000, he will attack all enemies
         * with his wakizashi (WakizashiMultiple).
         * If Yojimbo is paid 1000 or more, he will attack all enemies with Zanmato.
         * 
         * Once PerformAttack has been written, you should be able to get a different attack
         * by changing the payment value on the second line of Main.
         * 
         * In this assignment, you may alter any piece of the code but I only recommend you
         * alter the PerformAttack function and the 2nd line of Main, where you assign a
         * value to the payment variable.  There's no need to alter anything else but I
         * won't stop you
         */
        static void Main(string[] args)
        {
            Yojimbo yojimbo = new Yojimbo();
            int payment = 0;

            yojimbo.Payment = payment;
            yojimbo.PerformAttack();

            Console.WriteLine("Hello World!");
        }
    }
}
