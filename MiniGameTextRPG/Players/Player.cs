﻿using MiniGameTextRPG.Monsters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniGameTextRPG.Items;

namespace MiniGameTextRPG.Players
{
    public abstract class Player
    {
        protected string name;
        public string Name { get { return name; } }

        protected Job job;
        public Job Job { get { return job; } }

        public int curHP;
        public int CurHP { get { return curHP; } }

        public int maxHP;
        public int MaxHP { get { return maxHP; } }

        public int attack;
        public int Attack { get { return attack; } }

        public int defense;
        public int Defense { get { return defense; } }

        public int gold;
        public int Gold { get { return gold; } set { gold = value; } }

        public int exp;
        public int EXP { get { return exp; } set { exp = value; } }

        public event Action OnGainGold;
        public event Action OnGainExp;
        public void GainGold(int amount)
        {
            gold += amount;
            OnGainGold?.Invoke();
        }
        public void GainExp(int amount)
        {
            exp += amount;
            OnGainExp?.Invoke();
        }
        public abstract void Skill(Monster monster);

        public List<Item> Inventory { get; private set; } = new List<Item>();
        
        public void AddItem(Item item)
        {
            if (Inventory.Count < 5)
            {
                Inventory.Add(item);
            }
        }

        

        public void ShowInfo()
        {
            Console.SetCursorPosition(0, 12);
            Console.WriteLine("==========================================");
            Console.WriteLine($" 이름     : {name,-6} 직업 : {job,-6}");
            Console.WriteLine($" 체력     : {curHP,+3} / {maxHP}  공격 : {attack,-3} / 방어 : {defense,-3}");
            Console.WriteLine($" 골드     : {gold,+5} G");
            Console.WriteLine($" 경험치   : {exp,+5}");
            Console.WriteLine("==========================================");
            Console.WriteLine();
            Console.SetCursorPosition(0, 0);
        }
    }
}
