using System;
using System.Collections.Generic;
using System.Text;

namespace pig_dice.business {
    class PigDiceGame {
        public DateTime timestamp { get; set; }
        public int numRolls { get; set; }
        public int totalScore { get; set; }

        public PigDiceGame() {
            this.timestamp = new DateTime();
            this.numRolls = 0;
            this.totalScore = 0;
        }
    }
}
