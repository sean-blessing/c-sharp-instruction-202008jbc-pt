using ch07_product_manager.util;
using pig_dice.business;
using System;
using System.Collections.Generic;

namespace pig_dice {
    class Program {
        private static List<PigDiceGame> games = new List<PigDiceGame>();
 
        static void Main(string[] args) {
            Console.WriteLine("Pig Dice!");
            Console.WriteLine("Each game consists of die rolls until a 1 is rolled.");
            Console.WriteLine("You can play as many games as you like to try to reach the highest score.");
            int n = MyConsole.getInt("\nHow many games would you like to play?");
            PigDiceGame bestGame = new PigDiceGame();
            // game loop
            for (int i=0; i< n; i++) {
                PigDiceGame pdg = new PigDiceGame();
                int roll = 0;
                int total = 0;
                int rollCount = 0;
                while (roll!=1) {
                    rollCount++;
                    Random rand = new Random();
                    roll = rand.Next(1, 7);
                    total += roll;
                }
                Console.WriteLine("Game #" + i + " score: " + total);
                pdg.numRolls = rollCount;
                pdg.totalScore = total;
                if (total >= bestGame.totalScore)
                    bestGame = pdg;
                roll = 0;
                total = 0;
            }
            Console.WriteLine("==============================");
            Console.WriteLine("Total games:\t\t"+n);
            Console.WriteLine("Max Score:\t\t"+bestGame.totalScore);
            Console.WriteLine("# Rolls for Max:\t" + bestGame.numRolls);
            Console.WriteLine("==============================");
            // other ideas
            // store # of rolls for max score?
        }
    }
}
