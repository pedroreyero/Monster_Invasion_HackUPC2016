using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;

namespace Monster_Invasion
{
    static class Input
    {
        private static bool previousClickState;

        static Input()
        {
            previousClickState = false;
        }

        public static Vector2 GetKeyboardInput()
        {
            /* TODO: CODE
             * Compute the normalised vector for the direction of movement using the keyboard input
             * Return the vector
            */
        }

        public static Vector2 GetMouseInput(out bool hasPlayerFired)
        {
            /* TODO: CODE
             * Return the current position of the mouse as a Vector2
             * Returns (by reference) if the player has fired in the current iteration
             * Changes the value of the variable 'previousClickState'
            */
        }
    }
}
