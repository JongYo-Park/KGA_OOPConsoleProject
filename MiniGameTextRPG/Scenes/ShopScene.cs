using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniGameTextRPG.Scenes
{
    
    public class ShopScene : Scene
    {
        private string input;
        public ShopScene(Game game) : base(game)
        {
        }
        public override void Enter()
        {
            // TODO : 아이템 설정

            Console.Clear();
            Console.WriteLine("상점에 들어갑니다...");
            Thread.Sleep(2000);
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
            Console.WriteLine("상점이다.");
            Console.WriteLine();
            Console.WriteLine("어느것을 구매하시겠습니까?");
            Console.WriteLine("1. 체력 포션");
            Console.WriteLine("2. 공격력 증가 포션");
            Console.WriteLine("3. 방어력 증가 포션");
            Console.WriteLine("4. 레벨업 포션");
            Console.WriteLine("5. 마을로 돌아간다.");
            Console.Write("선택 : ");
        }

        public override void Update()
        {
            switch (input)
            {
                case "1":
                    //인벤토리에 체력 포션 추가
                    if (game.Player.Gold >= 50)
                    {
                        game.Player.Gold -= 50;
                        Console.Clear();
                        Console.WriteLine("체력 포션을 구입하였습니다!");

                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("잔액이 부족합니다....");
                    }
                    break;
                case "2":
                    //인벤토리에 공격력 증가 포션 추가
                    if (game.Player.Gold >= 50)
                    {
                        game.Player.Gold -= 50;
                        Console.Clear();
                        Console.WriteLine("공격력 증가 포션을 구입하였습니다!");
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("잔액이 부족합니다....");
                    }
                    break;
                case "3":
                    //인벤토리에 방어력 증가 포션 추가
                    if (game.Player.Gold >= 50)
                    {
                        game.Player.Gold -= 50;
                        Console.Clear();
                        Console.WriteLine("방어력 증가 포션을 구입하였습니다!");
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("잔액이 부족합니다....");
                    }
                    break;
                case "4":
                    //인벤토리에 레벨업 포션 추가
                    if (game.Player.Gold >= 100)
                    {
                        game.Player.Gold -= 100;
                        Console.Clear();
                        Console.WriteLine("레벨업 포션을 구입하였습니다!");
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("잔액이 부족합니다....");
                    }
                    break;
                case "5":
                    game.ChangeScene(SceneType.Town);
                    break;
                default: 
                    return;
            }
            Thread.Sleep(1000);
            return;

        }
    }
}
