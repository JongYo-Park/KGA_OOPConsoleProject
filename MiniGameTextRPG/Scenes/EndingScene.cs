﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniGameTextRPG.Scenes
{
    public class EndingScene : Scene
    {
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
            Console.ReadKey();
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
            Console.WriteLine("    계속하려면 아무키나 누르세요    ");
        }

        public override void Update()
        {
            game.ChangeScene(SceneType.Title);
        }
    }
}
