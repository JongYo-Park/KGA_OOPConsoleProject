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
                Console.WriteLine("사용할 아이템 번호를 입력하세요 (0 입력 시 마을로 돌아갑니다): ");
            }
            else
            {
                Console.WriteLine("소지하고 있는 아이템이 없습니다.");
                Console.WriteLine();
                Thread.Sleep(1000);
                Console.WriteLine("마을로 돌아가려면 아무키나 누르세요");
            }
        }

        public override void Update()
        {
            // TODO : 인벤토리 처리
            if (game.Player.Inventory.Count > 0)
            {
                switch (input)
                {
                    case "0":
                        game.ChangeScene(SceneType.Town);
                        break;
                    case "1":
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                    default:
                        return;


                }
            }
            game.ChangeScene(SceneType.Town);
        }
    }
}
