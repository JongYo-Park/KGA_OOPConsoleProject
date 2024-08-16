using MiniGameTextRPG.Monsters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniGameTextRPG.Players
{
    public class Rogue : Player
    {
        public Rogue(string name)
        {
            this.name = name;
            this.job = Job.Rogue;
            this.maxHP = 80;
            this.curHP = maxHP;
            this.attack = 40;
            this.defense = 20;
            this.gold = 0;
            this.exp = 0;
        }

        public override void Skill(Monster monster)
        {
            // TODO : 스킬 구현 (공격 x2)
            //RogueSkill = attack * 2;
            
        }
    }
}
