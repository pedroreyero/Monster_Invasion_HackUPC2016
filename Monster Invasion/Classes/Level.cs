using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;

namespace Monster_Invasion
{
    static class Level
    {
        private static enum LevelState
        {
            Resting,
            Spawning,
            Horde
        }

        public static Stage[] gameStages;
        public static int currentStage;
        public static LevelState levelState;
        private static int time_ref; // In seconds! :)

        static Level()
        {
            levelState = Resting; // CHECK IF IT'S CORRECT
            // TODO: Add stages of the game to the 'gameStages' array
        }

        public static void Update()
        {
            /* CHECK FOR STATE OF THE LEVEL
             * If resting: 20 sec before starting 'Spawning' state
             * If spawning: Spawn desired enemies and change to 'Horde' state
             * If horde: Check if all enemies are dead. If so
             *                                     1 - Clean enemy list
             *                                     2 - Change to 'Resting' state
             *                                     3 - Add 1 to currentStage
             *                                     4 - Start 'time_ref' countdown
            */
        }
    }
}
