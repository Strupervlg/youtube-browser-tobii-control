using Gma.System.MouseKeyHook;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tobii.Interaction;
using WindowsInput;

namespace webBrowser
{
    class EyeController
    {
        private static Point prevPos; //Предыдущая позиция взгляда
        private static bool hasPrevPos; //Флаг, что предыдущая позиция взгляда существует
        private static double alpha = 0.085d; 
        GazePointDataStream gazePointDataStream; //Поток данных с eye Tracker

        public static bool enableGazeMouseControl { get; set; } = false; //Флаг включения движения мыши с помощью eye Tracker

        /// <summary>
        /// Корректирует позицию взгляда
        /// </summary>
        /// <param name="point"> Позиция взгляда </param>
        /// <returns> Скорректированная позиция взгляда </returns>
        private static Point SmoothFilter(Point point)
        {
            Point filteredPoint = point;

            if (!hasPrevPos)
            {
                prevPos = point;
                hasPrevPos = true;
            }

            filteredPoint = new Point((int)(((double)point.X * alpha * 0.805d) + ((double)prevPos.X * (1.0d - alpha))),
                                      (int)(((double)point.Y * alpha * 0.82d)  + ((double)prevPos.Y * (1.0d - alpha))));

            prevPos = filteredPoint; //set the previous point to current point

            return filteredPoint;
        }

        /// <summary>
        /// Корректирует положение взгляда и перемещает курсор мыши
        /// </summary>
        /// <param name="x"> Координата взгляда по X </param>
        /// <param name="y"> Координата взгляда по Y </param>
        public static void moveCursor(int x, int y)
        {
            Cursor.Position = SmoothFilter(new Point(x, y));
        }

        /// <summary>
        /// Включает(Выключает) движение мыши с помощью eye Tracker
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void toggleGazeMouse(object sender, EventArgs e)
        {
            enableGazeMouseControl = !enableGazeMouseControl;
        }
    }
}
