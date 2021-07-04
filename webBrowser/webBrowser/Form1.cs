﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;

namespace webBrowser
{
    public partial class MainWindow : Form
    {
        bool isKeyboard = false;

        Thread threadProgressBar;
        System.Diagnostics.Process keyboardProc;

        ImageList imageListProgressButton = new ImageList();

        //Mouse actions
        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

        public MainWindow()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;

            string url = "https://www.youtube.com/watch?v=dQw4w9WgXcQ";
            browser.Navigate(url);

            imageListProgressButton.Images.Add("0", Properties.Resources._0);
            imageListProgressButton.Images.Add("1", Properties.Resources._1);
            imageListProgressButton.Images.Add("2", Properties.Resources._2);
            imageListProgressButton.Images.Add("3", Properties.Resources._3);
            imageListProgressButton.Images.Add("4", Properties.Resources._4);
            imageListProgressButton.Images.Add("5", Properties.Resources._5);
            imageListProgressButton.Images.Add("6", Properties.Resources._6);
            
        }

        private void buttonPausePlay_Click(object sender, EventArgs e)
        {
            browser.Document.InvokeScript("pausePlayVideo");
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            object[] arg = { "+" };
            browser.Document.InvokeScript("rewindVideo", arg);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            object[] arg = { "-" };
            browser.Document.InvokeScript("rewindVideo", arg);
        }

        private void buttonPlusVolume_Click(object sender, EventArgs e)
        {
            object[] arg = { "+" };
            browser.Document.InvokeScript("changeVolumeInVideo", arg);
        }

        private void buttonMinusVolume_Click(object sender, EventArgs e)
        {
            object[] arg = { "-" };
            browser.Document.InvokeScript("changeVolumeInVideo", arg);
        }

        private void buttonMuteVolume_Click(object sender, EventArgs e)
        {
            browser.Document.InvokeScript("muteVolumeInVideo");
        }

        private void buttonPlusRate_Click(object sender, EventArgs e)
        {
            object[] arg = { "+" };
            browser.Document.InvokeScript("changeRateInVideo", arg);
        }

        private void buttonMinusRate_Click(object sender, EventArgs e)
        {
            object[] arg = { "-" };
            browser.Document.InvokeScript("changeRateInVideo", arg);
        }

        private void buttonKeyboard_Click(object sender, EventArgs e)
        {
            //запускаем клавиатуру в отдельном потоке
            if(isKeyboard)
            {
                if(!keyboardProc.HasExited)
                {
                    keyboardProc.Kill();
                }                
                isKeyboard = false;
            }
            else
            {
                keyboardProc = System.Diagnostics.Process.Start("osk.exe");
                isKeyboard = true;
            }            
        }

        private void buttonClickMouse_Click(object sender, EventArgs e)
        {
            Thread threadClickMouse = new Thread(new ThreadStart(delegate
            {
                Thread.Sleep(2000);
                DoMouseClick();
            }));
            threadClickMouse.Start();
        }

        public void DoMouseClick()
        {
            //Call the imported function with the cursor's current position
            uint X = (uint)Cursor.Position.X;
            uint Y = (uint)Cursor.Position.Y;
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
        }

        private void setImageInButton(Button btn, ImageList imgList)
        {
            ImageList cpyImgList = imgList;
            for (int i = 0; i < 7; ++i)
            {
                Thread.Sleep(100);
                this.Invoke(new ThreadStart(delegate
                {
                    btn.BackgroundImage = cpyImgList.Images[i];
                }));
            }
        }

        private void buttons_MouseEnter(object sender, EventArgs e)
        {
            threadProgressBar = new Thread(new ThreadStart(delegate
            {
                setImageInButton(((Button)sender), imageListProgressButton);
                Invoke((MethodInvoker)delegate
                {
                    ((Button)sender).PerformClick();
                });
                Thread.Sleep(200);
                ((Button)sender).BackgroundImage = imageListProgressButton.Images[0];
            }));
            threadProgressBar.Start();
        }

        private void buttons_MouseLeave(object sender, EventArgs e)
        {
            threadProgressBar.Abort();
            ((Button)sender).BackgroundImage = imageListProgressButton.Images[0];
        }

        private void browser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            HtmlDocument doc = browser.Document;
            HtmlElement head = doc.GetElementsByTagName("head")[0];
            HtmlElement s = doc.CreateElement("script");
            s.SetAttribute("text", Properties.Resources.scriptJs);
            head.AppendChild(s);
        }        
    }
}
