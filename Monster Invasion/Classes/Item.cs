using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;

namespace Monster_Invasion
{
    class Item : GameItem
    {
        private enum ItemType
        {
            Heal,
            Coin
            // LifeUP,
            // PowerUP,
            // SpeedUP
        }

        public static List<Item> itemList;
        public ItemType tipus;

        static Item()
        {
            itemList = new List<Item>();
        }

        public Item(Vector2 position) : base(position)
        {
            itemList.Add(this);
            // TODO: Assign type

        }
    }
}
