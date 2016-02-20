using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Monster_Invasion
{
    abstract class GameItem
    {
        public Vector2 position;
        public Texture2D texture;

        protected GameItem(Vector2 position)
        {
            this.position = position;
        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, position, Color.White);
        }
    }
}
