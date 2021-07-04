using System;
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
        bool isPause = false;
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
            if (isPause)
            {
                HtmlDocument doc = browser.Document;
                HtmlElement head = doc.GetElementsByTagName("head")[0];
                HtmlElement s = doc.CreateElement("script");
                s.SetAttribute("text", "function playVideo() { document.getElementsByClassName('video-stream')[0].play(); }");
                head.AppendChild(s);
                browser.Document.InvokeScript("playVideo");
                isPause = false;
            }
            else
            {
                HtmlDocument doc = browser.Document;
                HtmlElement head = doc.GetElementsByTagName("head")[0];
                HtmlElement s = doc.CreateElement("script");
                s.SetAttribute("text", "function pauseVideo() { document.getElementsByClassName('video-stream')[0].pause(); }");
                head.AppendChild(s);
                browser.Document.InvokeScript("pauseVideo");
                isPause = true;
            }

        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            HtmlDocument doc = browser.Document;
            HtmlElement head = doc.GetElementsByTagName("head")[0];
            HtmlElement s = doc.CreateElement("script");
            s.SetAttribute("text", "function nextInVideo() { document.getElementsByClassName('video-stream')[0].currentTime += 5; }");
            head.AppendChild(s);
            browser.Document.InvokeScript("nextInVideo");
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            HtmlDocument doc = browser.Document;
            HtmlElement head = doc.GetElementsByTagName("head")[0];
            HtmlElement s = doc.CreateElement("script");
            s.SetAttribute("text", "function backInVideo() { document.getElementsByClassName('video-stream')[0].currentTime -= 5; }");
            head.AppendChild(s);
            browser.Document.InvokeScript("backInVideo");
        }

        private void buttonPlusVolume_Click(object sender, EventArgs e)
        {
            HtmlDocument doc = browser.Document;
            HtmlElement head = doc.GetElementsByTagName("head")[0];
            HtmlElement s = doc.CreateElement("script");
            s.SetAttribute("text",
                "    function changeVolumeInVideo(change) {" +
                "    var currentVolume = document.getElementsByClassName('video-stream')[0].volume;" +
                "    if(change == '+') {" +
                "        if(currentVolume < 0.99) {" +
                "            document.getElementsByClassName('video-stream')[0].volume += 0.1;" +
                "        }" +
                "        else {" +
                "            document.getElementsByClassName('video-stream')[0].volume = 1;" +
                "        }" +
                "    }" +
                "    else {" +
                "        if(currentVolume >= 0.1) {" +
                "            document.getElementsByClassName('video-stream')[0].volume -= 0.1;" +
                "        }" +
                "        else {" +
                "            document.getElementsByClassName('video-stream')[0].volume = 0;" +
                "        }" +
                "    } }");
            head.AppendChild(s);
            object[] arg = { "+" };
            browser.Document.InvokeScript("changeVolumeInVideo", arg);
        }

        private void buttonMinusVolume_Click(object sender, EventArgs e)
        {
            HtmlDocument doc = browser.Document;
            HtmlElement head = doc.GetElementsByTagName("head")[0];
            HtmlElement s = doc.CreateElement("script");
            s.SetAttribute("text",
                "    function changeVolumeInVideo(change) {" +
                "    var currentVolume = document.getElementsByClassName('video-stream')[0].volume;" +
                "    if(change == '+') {" +
                "        if(currentVolume < 0.99) {" +
                "            document.getElementsByClassName('video-stream')[0].volume += 0.1;" +
                "        }" +
                "        else {" +
                "            document.getElementsByClassName('video-stream')[0].volume = 1;" +
                "        }" +
                "    }" +
                "    else {" +
                "        if(currentVolume >= 0.1) {" +
                "            document.getElementsByClassName('video-stream')[0].volume -= 0.1;" +
                "        }" +
                "        else {" +
                "            document.getElementsByClassName('video-stream')[0].volume = 0;" +
                "        }" +
                "    } }");
            head.AppendChild(s);
            object[] arg = { "-" };
            browser.Document.InvokeScript("changeVolumeInVideo", arg);
        }

        private void buttonMuteVolume_Click(object sender, EventArgs e)
        {
            HtmlDocument doc = browser.Document;
            HtmlElement head = doc.GetElementsByTagName("head")[0];
            HtmlElement s = doc.CreateElement("script");
            s.SetAttribute("text",
                "function muteVolumeInVideo() {" +
                "    if(document.getElementsByClassName('video-stream')[0].muted) {" +
                "        document.getElementsByClassName('video-stream')[0].muted = false;" +
                "    }" +
                "    else {" +
                "        document.getElementsByClassName('video-stream')[0].muted = true;" +
                "    } }");
            head.AppendChild(s);
            browser.Document.InvokeScript("muteVolumeInVideo");
        }

        private void buttonPlusRate_Click(object sender, EventArgs e)
        {
            HtmlDocument doc = browser.Document;
            HtmlElement head = doc.GetElementsByTagName("head")[0];
            HtmlElement s = doc.CreateElement("script");
            s.SetAttribute("text",
                "function changeRateInVideo(change) {" +
                "    var rate = document.getElementsByClassName('video-stream')[0].playbackRate;" +
                "    if(change == '+') {" +
                "        if(rate < 2) {" +
                "            document.getElementsByClassName('video-stream')[0].playbackRate += 0.25;" +
                "        }" +
                "    }" +
                "    else {" +
                "        if(rate > 0.25) {" +
                "            document.getElementsByClassName('video-stream')[0].playbackRate -= 0.25;" +
                "        }" +
                "    } }");
            head.AppendChild(s);
            object[] arg = { "+" };
            browser.Document.InvokeScript("changeRateInVideo", arg);
        }

        private void buttonMinusRate_Click(object sender, EventArgs e)
        {
            HtmlDocument doc = browser.Document;
            HtmlElement head = doc.GetElementsByTagName("head")[0];
            HtmlElement s = doc.CreateElement("script");
            s.SetAttribute("text", "function changeRateInVideo(change) {" +
                "    var rate = document.getElementsByClassName('video-stream')[0].playbackRate;" +
                "    if(change == '+') {" +
                "        if(rate < 2) {" +
                "            document.getElementsByClassName('video-stream')[0].playbackRate += 0.25;" +
                "        }" +
                "    }" +
                "    else {" +
                "        if(rate > 0.25) {" +
                "            document.getElementsByClassName('video-stream')[0].playbackRate -= 0.25;" +
                "        }" +
                "    } }");
            head.AppendChild(s);
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
            s.SetAttribute("text", 
                "var coord = {x: window.innerWidth / 2, y: window.innerHeight / 2};" +
                "var SCROLL_AMOUNT = 10;" +
                "var SCROLL_THRESHOLD = 50;" +
                "function getPosition(e) {" +
                "   var x = y = 0;" +
                "   if (!e) {" +
                "      var e = window.event;" +
                "   }" +
                "   if (e.pageX || e.pageY) {" +
                "       x = e.pageX;" +
                "       y = e.pageY;" +
                "   }" +
                "   else if (e.clientX || e.clientY) {" +
                "       x = e.clientX + document.body.scrollLeft + document.documentElement.scrollLeft;" +
                "       y = e.clientY + document.body.scrollTop + document.documentElement.scrollTop;" +
                "   }" +
                "   return { x: x, y: y };" +
                "   }" +
                "function scrollPage() {" +
                "   var pageTop = window.pageYOffset;" +
                "   if (coord.y >= pageTop + window.innerHeight - SCROLL_THRESHOLD) {" +
                "       window.scrollBy(0, SCROLL_AMOUNT);" +
                "       coord.y += SCROLL_AMOUNT;" +
                "   }" +
                "   else if (coord.y <= pageTop + SCROLL_THRESHOLD) {" +
                "       window.scrollBy(0, -SCROLL_AMOUNT);" +
                "       coord.y -= SCROLL_AMOUNT;" +
                "   } " +
                "}" +
                "addEventListener('mousemove', function(e) {" +
                "   coord = getPosition(e);" +
                "}, true);" +
                "setInterval(scrollPage, 50);");
            head.AppendChild(s);
        }

        
    }
}
