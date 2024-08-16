using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniGameTextRPG.Players;

namespace MiniGameTextRPG.Items
{
    public class DefensePotion : Item
    {
        public DefensePotion() : base("방어력 증가 포션")
        {
        }

        public override void Use(Player player)
        {
            Console.Clear();
            Console.WriteLine("방어력 증가 포션을 사용하였습니다.");
            Thread.Sleep(1000);
            Console.WriteLine("방어력이 10 증가하였습니다.");
            player.defense += 10;
            Thread.Sleep(1000);
            
            
        }
    }
}
