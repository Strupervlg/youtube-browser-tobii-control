using System;
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

            MainWindow form = new MainWindow(); //Создание окна

            var host = new Host(); //Подключение к eye Tracker

            //Создание потока данных с eye Tracker
            var gazePointDataStream = host.Streams.CreateGazePointDataStream(Tobii.Interaction.Framework.GazePointDataMode.LightlyFiltered);

            //Включение движения мыши с помощью eye Tracker при активации окна
            form.Activated += new System.EventHandler(EyeController.toggleGazeMouse);

            //Получение координат взгляда с eye Tracker и отрисовка в заданной позиции курсора
            gazePointDataStream.GazePoint((x, y, _) =>
            {
                if (EyeController.enableGazeMouseControl)
                {
                    EyeController.moveCursor((int)x, (int)y);
                }
            });

            //Запуск окна
            Application.Run(form);
        }
    }
}
