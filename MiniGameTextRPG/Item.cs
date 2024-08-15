using MiniGameTextRPG.Players;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniGameTextRPG
{
    public abstract class Item
    {
        public string Name { get; set; }

        protected Item(string name)
        {
            Name = name;
        }

        
        public override string ToString()
        {
            return Name;
        }
    }

    public class HealingPotion : Item
    {
        public HealingPotion() : base("체력 회복 포션")
        {
        }
    }

    public class PowerPotion : Item
    {
        public PowerPotion() : base("공격력 증가 포션")
        {
        }
    }

    public class DefensePotion : Item
    {
        public DefensePotion() : base("방어력 증가 포션")
        {
        }
    }

    public class LvUpPotion : Item
    {
        public LvUpPotion() : base("레벨 업 포션")
        {
        }
    }
}
