using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;

namespace Monster_Invasion
{
    class Enemy : Sprite
    {
        public static List<Enemy> enemyList;
        private byte life;
        private byte power;

        static Enemy()
        {
            enemyList = new List<Enemy>();
        }

        public Enemy(Vector2 position, Vector2 direction, byte life, byte power) : base(position, direction)
        {
            this.life = life;
            this.power = power;
        }

        public new virtual void Update(Player player)
        {
            /* TODO: CODE
             * Look for the player
             * Seek the player
             * Be really really bad >:)
            */
        }
    }
}
