using MiniGameTextRPG.Monsters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniGameTextRPG.Players
{
    public class Mage : Player
    {
        public Mage(string name)
        {
            this.name = name;
            this.job = Job.Mage;
            this.maxHP = 50;
            this.curHP = maxHP;
            this.attack = 50;
            this.defense = 10;
            this.gold = 100;
            this.exp = 0;
        }

        public override void Skill(Monster monster)
        {
            // TODO : 스킬 구현 (단단한 타입 몬스터에게 큰 효과)
            //monster.curHP -= this.attack * 2;
        }
    }
}
