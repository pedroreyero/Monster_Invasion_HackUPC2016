using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;

namespace Monster_Invasion
{
    class Projectile : Sprite
    {
        public static List<Projectile> projectileList;

        static Projectile()
        {
            projectileList = new List<Projectile>();
        }

        public Projectile(Vector2 position, Vector2 direction) : base(position, direction)
        {
            projectileList.Add(this);
        }

        public override void Update()
        {
            base.Update();

            /* TODO: CODE
             * Check for "out of the limits"
             * Kill itself if so
            */
        }
    }
}
