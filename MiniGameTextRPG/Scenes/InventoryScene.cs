using MiniGameTextRPG.Items;

namespace MiniGameTextRPG.Scenes
{
    public class InventoryScene : Scene
    {
        private string input;
        public InventoryScene(Game game) : base(game)
        {
        }

        public override void Enter()
        {
            Console.Clear();
            Console.WriteLine("인벤토리를 엽니다...");

            Thread.Sleep(1000);
        }

        public override void Exit()
        {

        }

        public override void Input()
        {
            input = Console.ReadLine();
        }

        public override void Render()
        {
            Console.Clear();
            game.Player.ShowInfo();
            Console.WriteLine("<인벤토리>");

            if (game.Player.Inventory.Count > 0)
            {
                for (int i = 0; i < game.Player.Inventory.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {game.Player.Inventory[i]}");
                }
                Console.WriteLine("사용할 아이템 번호를 입력하세요.(0을 누르면 마을로 돌아갑니다) : ");
            }
            else
            {
                Console.WriteLine("소지하고 있는 아이템이 없습니다.");
                Console.WriteLine();
                Thread.Sleep(1000);
                Console.WriteLine("마을로 돌아가려면 아무키나 누르세요.");
            }
        }

        public override void Update()
        {
            if (game.Player.Inventory.Count > 0) 
            {
                if (int.TryParse(input, out int num) && num >= 0 && num <= game.Player.Inventory.Count)
                {
                    if (num == 0)
                    {
                        game.ChangeScene(SceneType.Town);
                    }
                    else
                    {
                        Item item = game.Player.Inventory[num - 1];
                        item.Use(game.Player);
                        game.Player.Inventory.RemoveAt(num - 1); 
                    }
                }
                else
                {
                    Console.WriteLine("잘못된 입력입니다. 다시 시도하세요.");
                    Thread.Sleep(1000);
                }
            }
            else
            {
                game.ChangeScene(SceneType.Town);
            }
        }
    }
}
