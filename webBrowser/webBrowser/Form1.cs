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

namespace webBrowser
{
    public partial class MainWindow : Form
    {
        bool isPause = false;
        bool isKeyboard = false;

        Thread threadProgressBar;
        System.Diagnostics.Process keyboardProc;

        ImageList imageListProgressPlayPause = new ImageList();
        ImageList imageListProgressNext = new ImageList();
        ImageList imageListProgressBack = new ImageList();
        ImageList imageListProgressPlusVolume = new ImageList();
        ImageList imageListProgressMinusVolume = new ImageList();
        ImageList imageListProgressMuteVolume = new ImageList();
        ImageList imageListProgressPlusRate = new ImageList();
        ImageList imageListProgressMinusRate = new ImageList();
        ImageList imageListProgressKeyboard = new ImageList();

        public MainWindow()
        {
            InitializeComponent();
            string url = "https://www.youtube.com/watch?v=dQw4w9WgXcQ";
            browser.Navigate(url);

            imageListProgressPlayPause.Images.Add("0", Properties.Resources._0);
            imageListProgressPlayPause.Images.Add("1", Properties.Resources._1);
            imageListProgressPlayPause.Images.Add("2", Properties.Resources._2);
            imageListProgressPlayPause.Images.Add("3", Properties.Resources._3);
            imageListProgressPlayPause.Images.Add("4", Properties.Resources._4);
            imageListProgressPlayPause.Images.Add("5", Properties.Resources._5);
            imageListProgressPlayPause.Images.Add("6", Properties.Resources._6);

            imageListProgressNext.Images.Add("0", Properties.Resources._0);
            imageListProgressNext.Images.Add("1", Properties.Resources._1);
            imageListProgressNext.Images.Add("2", Properties.Resources._2);
            imageListProgressNext.Images.Add("3", Properties.Resources._3);
            imageListProgressNext.Images.Add("4", Properties.Resources._4);
            imageListProgressNext.Images.Add("5", Properties.Resources._5);
            imageListProgressNext.Images.Add("6", Properties.Resources._6);

            imageListProgressBack.Images.Add("0", Properties.Resources._0);
            imageListProgressBack.Images.Add("1", Properties.Resources._1);
            imageListProgressBack.Images.Add("2", Properties.Resources._2);
            imageListProgressBack.Images.Add("3", Properties.Resources._3);
            imageListProgressBack.Images.Add("4", Properties.Resources._4);
            imageListProgressBack.Images.Add("5", Properties.Resources._5);
            imageListProgressBack.Images.Add("6", Properties.Resources._6);

            imageListProgressPlusVolume.Images.Add("0", Properties.Resources._0);
            imageListProgressPlusVolume.Images.Add("1", Properties.Resources._1);
            imageListProgressPlusVolume.Images.Add("2", Properties.Resources._2);
            imageListProgressPlusVolume.Images.Add("3", Properties.Resources._3);
            imageListProgressPlusVolume.Images.Add("4", Properties.Resources._4);
            imageListProgressPlusVolume.Images.Add("5", Properties.Resources._5);
            imageListProgressPlusVolume.Images.Add("6", Properties.Resources._6);

            imageListProgressMinusVolume.Images.Add("0", Properties.Resources._0);
            imageListProgressMinusVolume.Images.Add("1", Properties.Resources._1);
            imageListProgressMinusVolume.Images.Add("2", Properties.Resources._2);
            imageListProgressMinusVolume.Images.Add("3", Properties.Resources._3);
            imageListProgressMinusVolume.Images.Add("4", Properties.Resources._4);
            imageListProgressMinusVolume.Images.Add("5", Properties.Resources._5);
            imageListProgressMinusVolume.Images.Add("6", Properties.Resources._6);

            imageListProgressMuteVolume.Images.Add("0", Properties.Resources._0);
            imageListProgressMuteVolume.Images.Add("1", Properties.Resources._1);
            imageListProgressMuteVolume.Images.Add("2", Properties.Resources._2);
            imageListProgressMuteVolume.Images.Add("3", Properties.Resources._3);
            imageListProgressMuteVolume.Images.Add("4", Properties.Resources._4);
            imageListProgressMuteVolume.Images.Add("5", Properties.Resources._5);
            imageListProgressMuteVolume.Images.Add("6", Properties.Resources._6);

            imageListProgressPlusRate.Images.Add("0", Properties.Resources._0);
            imageListProgressPlusRate.Images.Add("1", Properties.Resources._1);
            imageListProgressPlusRate.Images.Add("2", Properties.Resources._2);
            imageListProgressPlusRate.Images.Add("3", Properties.Resources._3);
            imageListProgressPlusRate.Images.Add("4", Properties.Resources._4);
            imageListProgressPlusRate.Images.Add("5", Properties.Resources._5);
            imageListProgressPlusRate.Images.Add("6", Properties.Resources._6);

            imageListProgressMinusRate.Images.Add("0", Properties.Resources._0);
            imageListProgressMinusRate.Images.Add("1", Properties.Resources._1);
            imageListProgressMinusRate.Images.Add("2", Properties.Resources._2);
            imageListProgressMinusRate.Images.Add("3", Properties.Resources._3);
            imageListProgressMinusRate.Images.Add("4", Properties.Resources._4);
            imageListProgressMinusRate.Images.Add("5", Properties.Resources._5);
            imageListProgressMinusRate.Images.Add("6", Properties.Resources._6);

            imageListProgressKeyboard.Images.Add("0", Properties.Resources._0);
            imageListProgressKeyboard.Images.Add("1", Properties.Resources._1);
            imageListProgressKeyboard.Images.Add("2", Properties.Resources._2);
            imageListProgressKeyboard.Images.Add("3", Properties.Resources._3);
            imageListProgressKeyboard.Images.Add("4", Properties.Resources._4);
            imageListProgressKeyboard.Images.Add("5", Properties.Resources._5);
            imageListProgressKeyboard.Images.Add("6", Properties.Resources._6);
            
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

        private void buttonPausePlay_MouseEnter(object sender, EventArgs e)
        {
            imageListProgressPlayPause.ImageSize = buttonPausePlay.Size;
            threadProgressBar = new Thread(new ThreadStart(delegate
            {
                for (int i = 0; i < 7; ++i)
                {
                    Thread.Sleep(100);
                    this.Invoke(new ThreadStart(delegate
                    {
                        buttonPausePlay.BackgroundImage = imageListProgressPlayPause.Images[i];
                    }));
                }
                Invoke((MethodInvoker)delegate
                {
                    buttonPausePlay_Click(null, null);
                });
                Thread.Sleep(200);
                buttonPausePlay.BackgroundImage = imageListProgressPlayPause.Images[0];
            }));
            threadProgressBar.Start();
        }

        private void buttonPausePlay_MouseLeave(object sender, EventArgs e)
        {
            threadProgressBar.Abort();
            buttonPausePlay.BackgroundImage = imageListProgressPlayPause.Images[0];
        }

        private void buttonNext_MouseEnter(object sender, EventArgs e)
        {
            imageListProgressNext.ImageSize = buttonNext.Size;
            threadProgressBar = new Thread(new ThreadStart(delegate
            {
                for (int i = 0; i < 7; ++i)
                {
                    Thread.Sleep(100);
                    this.Invoke(new ThreadStart(delegate
                    {
                        //System.Console.WriteLine(imageListProgress.Images.IndexOfKey("1"));
                        buttonNext.BackgroundImage = imageListProgressNext.Images[i];
                    }));
                }
                Invoke((MethodInvoker)delegate
                {
                    buttonNext_Click(null, null);
                });
                Thread.Sleep(200);
                buttonNext.BackgroundImage = imageListProgressNext.Images[0];
            }));
            threadProgressBar.Start();
        }

        private void buttonNext_MouseLeave(object sender, EventArgs e)
        {
            threadProgressBar.Abort();
            buttonNext.BackgroundImage = imageListProgressNext.Images[0];
        }

        private void buttonBack_MouseEnter(object sender, EventArgs e)
        {
            imageListProgressBack.ImageSize = buttonBack.Size;
            threadProgressBar = new Thread(new ThreadStart(delegate
            {
                for (int i = 0; i < 7; ++i)
                {
                    Thread.Sleep(100);
                    this.Invoke(new ThreadStart(delegate
                    {
                        buttonBack.BackgroundImage = imageListProgressBack.Images[i];
                    }));
                }
                Invoke((MethodInvoker)delegate
                {
                    buttonBack_Click(null, null);
                });
                Thread.Sleep(200);
                buttonBack.BackgroundImage = imageListProgressBack.Images[0];
            }));
            threadProgressBar.Start();
        }

        private void buttonBack_MouseLeave(object sender, EventArgs e)
        {
            threadProgressBar.Abort();
            buttonBack.BackgroundImage = imageListProgressBack.Images[0];
        }

        private void buttonPlusVolume_MouseEnter(object sender, EventArgs e)
        {
            imageListProgressPlusVolume.ImageSize = buttonPlusVolume.Size;
            threadProgressBar = new Thread(new ThreadStart(delegate
            {
                for (int i = 0; i < 7; ++i)
                {
                    Thread.Sleep(100);
                    this.Invoke(new ThreadStart(delegate
                    {
                        buttonPlusVolume.BackgroundImage = imageListProgressPlusVolume.Images[i];
                    }));
                }
                Invoke((MethodInvoker)delegate
                {
                    buttonPlusVolume_Click(null, null);
                });
                Thread.Sleep(200);
                buttonPlusVolume.BackgroundImage = imageListProgressPlusVolume.Images[0];
            }));
            threadProgressBar.Start();
        }

        private void buttonPlusVolume_MouseLeave(object sender, EventArgs e)
        {
            threadProgressBar.Abort();
            buttonPlusVolume.BackgroundImage = imageListProgressPlusVolume.Images[0];
        }

        private void buttonMinusVolume_MouseEnter(object sender, EventArgs e)
        {
            imageListProgressMinusVolume.ImageSize = buttonMinusVolume.Size;
            threadProgressBar = new Thread(new ThreadStart(delegate
            {
                for (int i = 0; i < 7; ++i)
                {
                    Thread.Sleep(100);
                    this.Invoke(new ThreadStart(delegate
                    {
                        buttonMinusVolume.BackgroundImage = imageListProgressMinusVolume.Images[i];
                    }));
                }
                Invoke((MethodInvoker)delegate
                {
                    buttonMinusVolume_Click(null, null);
                });
                Thread.Sleep(200);
                buttonMinusVolume.BackgroundImage = imageListProgressMinusVolume.Images[0];
            }));
            threadProgressBar.Start();
        }

        private void buttonMinusVolume_MouseLeave(object sender, EventArgs e)
        {
            threadProgressBar.Abort();
            buttonMinusVolume.BackgroundImage = imageListProgressMinusVolume.Images[0];
        }

        private void buttonMuteVolume_MouseEnter(object sender, EventArgs e)
        {
            imageListProgressMuteVolume.ImageSize = buttonMuteVolume.Size;
            threadProgressBar = new Thread(new ThreadStart(delegate
            {
                for (int i = 0; i < 7; ++i)
                {
                    Thread.Sleep(100);
                    this.Invoke(new ThreadStart(delegate
                    {
                        buttonMuteVolume.BackgroundImage = imageListProgressMuteVolume.Images[i];
                    }));
                }
                Invoke((MethodInvoker)delegate
                {
                    buttonMuteVolume_Click(null, null);
                });
                Thread.Sleep(200);
                buttonMuteVolume.BackgroundImage = imageListProgressMuteVolume.Images[0];
            }));

            threadProgressBar.Start();
        }

        private void buttonMuteVolume_MouseLeave(object sender, EventArgs e)
        {
            threadProgressBar.Abort();
            buttonMuteVolume.BackgroundImage = imageListProgressMuteVolume.Images[0];
        }

        private void buttonPlusRate_MouseEnter(object sender, EventArgs e)
        {
            imageListProgressPlusRate.ImageSize = buttonPlusRate.Size;
            threadProgressBar = new Thread(new ThreadStart(delegate
            {
                for (int i = 0; i < 7; ++i)
                {
                    Thread.Sleep(100);
                    this.Invoke(new ThreadStart(delegate
                    {
                        buttonPlusRate.BackgroundImage = imageListProgressPlusRate.Images[i];
                    }));
                }
                Invoke((MethodInvoker)delegate
                {
                    buttonPlusRate_Click(null, null);
                });
                Thread.Sleep(200);
                buttonPlusRate.BackgroundImage = imageListProgressPlusRate.Images[0];
            }));
            threadProgressBar.Start();
        }

        private void buttonPlusRate_MouseLeave(object sender, EventArgs e)
        {
            threadProgressBar.Abort();
            buttonPlusRate.BackgroundImage = imageListProgressPlusRate.Images[0];
        }

        private void buttonMinusRate_MouseEnter(object sender, EventArgs e)
        {
            imageListProgressMinusRate.ImageSize = buttonMinusRate.Size;
            threadProgressBar = new Thread(new ThreadStart(delegate
            {
                for (int i = 0; i < 7; ++i)
                {
                    Thread.Sleep(100);
                    this.Invoke(new ThreadStart(delegate
                    {
                        buttonMinusRate.BackgroundImage = imageListProgressMinusRate.Images[i];
                    }));
                }
                Invoke((MethodInvoker)delegate
                {
                    buttonMinusRate_Click(null, null);
                });
                Thread.Sleep(200);
                buttonMinusRate.BackgroundImage = imageListProgressMinusRate.Images[0];
            }));
            threadProgressBar.Start();
        }

        private void buttonMinusRate_MouseLeave(object sender, EventArgs e)
        {
            threadProgressBar.Abort();
            buttonMinusRate.BackgroundImage = imageListProgressMinusRate.Images[0];
        }

        private void buttonKeyboard_MouseEnter(object sender, EventArgs e)
        {
            imageListProgressKeyboard.ImageSize = buttonKeyboard.Size;
            threadProgressBar = new Thread(new ThreadStart(delegate
            {
                for (int i = 0; i < 7; ++i)
                {
                    Thread.Sleep(100);
                    this.Invoke(new ThreadStart(delegate
                    {
                        buttonKeyboard.BackgroundImage = imageListProgressKeyboard.Images[i];   
                    }));
                }
                Invoke((MethodInvoker)delegate
                {
                    buttonKeyboard_Click(null, null);
                });
                Thread.Sleep(200);
                buttonKeyboard.BackgroundImage = imageListProgressKeyboard.Images[0];
            }));
            threadProgressBar.Start();
        }

        private void buttonKeyboard_MouseLeave(object sender, EventArgs e)
        {
            threadProgressBar.Abort();
            buttonKeyboard.BackgroundImage = imageListProgressKeyboard.Images[0];
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
