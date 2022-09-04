using System;
using SadConsole;
using Console = SadConsole.Console;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace MyProject
{
    class Program
    {

        public const int Width = 120;
        public const int Height = 60;

        static void Main(string[] args)
        {
            // Setup the engine and create the main window.
            SadConsole.Game.Create(Width, Height);

            // Hook the start event so we can add consoles to the system.
            SadConsole.Game.OnInitialize = Init;

            SadConsole.Game.Instance.Run();
            SadConsole.Game.Instance.Dispose();
        }

        private static void Init()
        {
            // Any startup code for your game. We will use an example console for now
            var startingConsole = SadConsole.Global.CurrentScreen;
            startingConsole.FillWithRandomGarbage();
            startingConsole.Fill(new Rectangle(33, 15, 60, 30), null, Color.Black, 0, SpriteEffects.None);
            startingConsole.Print(55, 30, "Hello SadConsole!", ColorAnsi.CyanBright);
        }
    }
}