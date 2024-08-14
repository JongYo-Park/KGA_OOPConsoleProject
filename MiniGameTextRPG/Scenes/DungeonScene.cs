using MiniGameTextRPG.Monsters;
using MiniGameTextRPG.Players;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniGameTextRPG.Scenes
{
    public class DungeonScene : Scene
    {
        private Monster monster;
        private Player player;

        private string input;

        public DungeonScene(Game game) : base(game)
        {

            //배틀씬이 만들어졌을 때 초기화 과정
        }

        public void SetMonster(Monster monster)
        {

            this.monster = monster;
        }

        public override void Enter()
        {
            // TODO : 랜덤 몬스터 출연

            monster = new Monster();
            monster.name = "더미 몬스터";
            monster.maxHP = 100;
            monster.curHP = monster.maxHP;
            monster.attack = 10;
            monster.defense = 10;

            Console.Clear();
            Console.WriteLine($"{monster.name} 이/가 나타났다!!!");
            Thread.Sleep(2000);
        }

        public override void Exit()
        {
            //배틀씬에 나갔을 때 작업
        }

        public override void Input()
        {
            // TODO : 전투 입력
            input = Console.ReadLine();
        }

        public override void Render()
        {
            // TODO : 전투 상황 출력
            Console.Clear();
            PrintMonster();
            Console.WriteLine();
            Console.WriteLine("1. 공격");
            Console.WriteLine("2. 방어");
            //Console.WriteLine("3. 스킬");
            Console.WriteLine("4. 도망");
            Console.WriteLine("행동을 선택해주세요 : ");

            game.Player.ShowInfo();
        }
        string battleInput = Console.ReadLine();

        public override void Update()
        {
            // TODO : 전투 진행
            Console.Clear();
            switch (battleInput)
            {
                case "1":
                    Console.Clear();
                    PrintMonster();
                    Console.WriteLine();
                    Console.WriteLine("플레이어가 공격합니다");
                    if (player.attack > monster.defense)
                    {
                        if (monster.curHP - player.attack <= 0)
                        {
                            Console.Clear();
                            Console.WriteLine("효과는 굉장했습니다!");
                            Thread.Sleep(1000);
                            Console.WriteLine("더미 몬스터가 쓰러졌습니다.");
                            Thread.Sleep(1000);
                            Console.WriteLine("보상으로 100골드와 10경험치를 획득합니다.");
                            Thread.Sleep(1000);
                            player.GainGold(100);
                            Thread.Sleep(1000);
                            player.GainExp(10);
                            Thread.Sleep(1000);
                            game.ChangeScene(SceneType.Town);
                            break;
                        }
                        else if (monster.curHP - player.attack > 0)
                        {
                            monster.curHP -= player.attack;
                            Console.WriteLine("몬스터가 반격합니다");
                            Thread.Sleep(1000);
                            if (player.curHP - monster.attack < 0)
                            {
                                Console.WriteLine("플레이어가 쓰러졌습니다...");
                                Thread.Sleep(1000);
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("효과가 없습니다..");
                        Thread.Sleep(1000);
                    }
                    break;
                case "2":
                    break;
                case "4":
                    Console.WriteLine("도망갑니다....");
                    Thread.Sleep(2000);
                    game.ChangeScene(SceneType.Town);
                    break;
                default:
                    //Console.Clear();
                    //Console.WriteLine("유효하지 않은 입력입니다. 다시 입력해주세요.");
                    //Thread.Sleep(2000);
                    return;
            }

        }

        private void PrintMonster()
        {
            Console.WriteLine($"몬스터 : {monster.name}");
            Console.WriteLine($"체력 : {monster.curHP}");
            Console.WriteLine($"공격력 : {monster.attack}");
            Console.WriteLine($"방어력 : {monster.defense}");
        }
    }
}
