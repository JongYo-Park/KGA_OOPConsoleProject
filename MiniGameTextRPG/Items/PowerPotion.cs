using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniGameTextRPG.Players;

namespace MiniGameTextRPG.Items
{
    public class PowerPotion : Item
    {
        public PowerPotion() : base("공격력 증가 포션")
        {
        }

        public override void Use(Player player)
        {
            Console.Clear();
            Console.WriteLine("공격력 증가 포션을 사용하였습니다.");
            Thread.Sleep(1000);
            Console.WriteLine("공격력이 10 증가하였습니다.");
            player.attack += 10;
            Thread.Sleep(1000);
        }
    }
}
