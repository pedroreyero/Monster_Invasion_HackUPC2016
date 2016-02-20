using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;


namespace Monster_Invasion
{
    class Sprite : GameItem
    {
        public Vector2 direction; // NORMALISED!!
        public float speed;

        public Sprite(Vector2 position, Vector2 direction) : base(position)
        {
            this.direction = direction;
        }

        public virtual void Update()
        {
            position += direction * speed;
        }
    }
}
