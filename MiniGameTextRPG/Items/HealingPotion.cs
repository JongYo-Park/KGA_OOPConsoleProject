using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniGameTextRPG.Players;

namespace MiniGameTextRPG.Items
{
    public class HealingPotion : Item
    {
        //플레이어 curHP += 50
        public HealingPotion() : base("체력 회복 포션")
        {

        }

        public override void Use(Player player)
        {
            Console.Clear();
            Console.WriteLine("체력 회복 포션을 사용하였습니다.");
            player.curHP += 50;
            Thread.Sleep(1000);
            if (player.curHP > player.maxHP)
            {
                player.curHP = player.maxHP;
            }
        }
    }
}
