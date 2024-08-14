using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniGameTextRPG
{
    public enum SceneType { Title, Select, Town, Map, Dungeon, Inventory, Shop, GameOver, Size }

    public enum Job { Warrior = 1, Mage, Rogue }

    public enum ItemType { Potion, Weapon, Armor, Food }
}
