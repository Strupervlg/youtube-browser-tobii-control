﻿using Gma.System.MouseKeyHook;
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
        private static Point prevPos;
        private static bool hasPrevPos;
        private static double alpha = 0.085d;
        GazePointDataStream gazePointDataStream;

        public static bool enableGazeMouseControl { get; set; } = false;

        //Applies a filter to the point based on currently selected setting
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

        //Moves the mouse cursor and applies filter based on the currently selected setting
        public static void moveCursor(int x, int y)
        {
            Cursor.Position = SmoothFilter(new Point(x, y));
        }
        public static void toggleGazeMouse(object sender, EventArgs e)
        {
            enableGazeMouseControl = !enableGazeMouseControl;
        }
    }
}
