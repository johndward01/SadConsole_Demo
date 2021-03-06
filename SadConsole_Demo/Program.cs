﻿using System;
using SadConsole;
using Console = SadConsole.Console;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace MyProject
{
    class Program
    {

        public const int Width = 80;
        public const int Height = 25;

        static void Main(string[] args)
        {
            // Setup the engine and create the main window.
            SadConsole.Game.Create(Width, Height);

            // Hook the start event so we can add consoles to the system.
            SadConsole.Game.OnInitialize = Init;

            // Start the game.

            // TODO: Uncomment the Run() method below

            //SadConsole.Game.Instance.Run();
            SadConsole.Game.Instance.Dispose();
        }

        private static void Init()
        {
            // Any startup code for your game. We will use an example console for now
            var startingConsole = SadConsole.Global.CurrentScreen;

            // TODO: Uncomment the method below to call the FillWithRandomGarbage() method

            //startingConsole.FillWithRandomGarbage();
            startingConsole.Fill(new Rectangle(3, 3, 27, 5), null, Color.Black, 0, SpriteEffects.None);
            startingConsole.Print(6, 5, "Hello SadConsole!", ColorAnsi.CyanBright);
        }
    }
}