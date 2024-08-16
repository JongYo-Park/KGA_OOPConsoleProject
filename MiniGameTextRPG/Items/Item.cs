using MiniGameTextRPG.Scenes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniGameTextRPG.Players;

namespace MiniGameTextRPG.Items
{
    public abstract class Item
    {
        public string Name { get; set; }
        
        protected Item(string name)
        {
            Name = name;
        }

        public abstract void Use(Player player);

        public override string ToString()
        {
            return Name;
        }
    }
}
