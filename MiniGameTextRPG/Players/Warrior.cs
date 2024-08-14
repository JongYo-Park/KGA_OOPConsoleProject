using MiniGameTextRPG.Monsters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniGameTextRPG.Players
{
    public class Warrior : Player
    {
        public Warrior(string name)
        {
            this.name = name;
            this.job = Job.Warrior;
            this.maxHP = 120;
            this.curHP = maxHP;
            this.attack = 20;
            this.defense = 40;
            this.gold = 50;
            this.exp = 0;
        }

        public override void Skill(Monster monster)
        {
            // TODO : 스킬 구현
        }
    }
}
