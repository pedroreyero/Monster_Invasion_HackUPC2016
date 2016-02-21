using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;

namespace Monster_Invasion
{
    class Player : Sprite
    {
        const byte INI_LIFE = 5;
        const byte MAX_LIFE = 10;
        const byte INI_POWER = 1;
        const byte MAX_POWER = 4;
        const byte INI_SPEED = 1;
        const byte MAX_SPEED = 3;

        private static Texture2D pointer;

        public byte life;
        public byte score;
        public byte power;
        public byte speed;

        static Player()
        {
            // TODO: Set pointer's texture / image
        }

        public Player(Vector2 position): base(position, Vector2.Zero)
        {
            this.life = INI_LIFE;
            this.score = 0;
            this.power = INI_POWER;
            this.speed = INI_SPEED;
        }

        public override void Update()
        {
            /* TODO: CODE
             * Point the cursor. Shoot a projectile if necessary (MOUSE INOUT)
             * Check death
            */

            base.Update();
        }

        private void Shoot(Vector2 direction)
        {
            // TODO
        }
    }
}
