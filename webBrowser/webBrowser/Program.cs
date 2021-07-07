﻿using System;
using System.Windows.Forms;
using Tobii.Interaction;
using WindowsInput;
using Gma.System.MouseKeyHook;

namespace webBrowser
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MainWindow form = new MainWindow();

            var host = new Host();

            //create the data stream
            var gazePointDataStream = host.Streams.CreateGazePointDataStream(Tobii.Interaction.Framework.GazePointDataMode.LightlyFiltered);

            //handle the 'toggle gaze control' button event
            form.Activated += new System.EventHandler(EyeController.toggleGazeMouse);

            gazePointDataStream.GazePoint((x, y, _) =>
            {
                if (EyeController.enableGazeMouseControl)
                {
                    EyeController.moveCursor((int)x, (int)y);
                }
            });

            Application.Run(form);
        }
    }
}
