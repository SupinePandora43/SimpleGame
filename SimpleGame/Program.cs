﻿using System;
using OpenTK.Windowing.Desktop;

namespace SimpleGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var nws = new NativeWindowSettings
            {
                Title = "SimpleGame",
                Size = new OpenTK.Mathematics.Vector2i(800, 600)
            };

            var gws = new GameWindowSettings
            {
                IsMultiThreaded = false,
                RenderFrequency = 300,
                UpdateFrequency = 300,
            };

            App app = new App(gws, nws);
            app.Run();
        }
    }
}
