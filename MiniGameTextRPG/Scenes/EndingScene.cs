using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MiniGameTextRPG.Scenes.SelectScene;

namespace MiniGameTextRPG.Scenes
{
    public class EndingScene : Scene
    {
        private string input;
        public EndingScene(Game game) : base(game)
        {
        }

        public override void Enter()
        {

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
            Console.WriteLine("====================================");
            Console.WriteLine("=                                  =");
            Console.WriteLine("=            Game  Over            =");
            Console.WriteLine("=                                  =");
            Console.WriteLine("====================================");
            Console.WriteLine();
            Console.WriteLine("     다시 시작하시겠습니까?(y/n)     ");
        }

        public override void Update()
        {
            switch (input)
            {
                case "Y":
                case "y":
                    game.ChangeScene(SceneType.Title);
                    break;
                case "N":
                case "n":
                    Console.Clear();
                    game.Over();
                    break;
                default:
                    break;
            }
        }
    }
}
