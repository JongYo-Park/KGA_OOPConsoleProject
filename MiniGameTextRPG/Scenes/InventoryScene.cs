using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniGameTextRPG.Scenes
{
    public class InventoryScene : Scene
    {
        public InventoryScene(Game game) : base(game)
        {
        }

        public override void Enter()
        {
            // TODO : 인벤토리 설정

            Console.Clear();
            Console.WriteLine("인벤토리를 엽니다...");

            Thread.Sleep(1000);
        }

        public override void Exit()
        {

        }

        public override void Input()
        {
            Console.ReadKey();
        }

        public override void Render()
        {
            Console.Clear();
            game.Player.ShowInfo();
            Console.WriteLine("<인벤토리>");
            //Console.WriteLine($"{가지고 있는 포션 나열}");
            Thread.Sleep(2000);
            Console.WriteLine();
            Console.WriteLine("마을로 돌아가려면 아무키나 누르세요");
        }

        public override void Update()
        {
            // TODO : 인벤토리 처리

            game.ChangeScene(SceneType.Town);
        }
    }
}
